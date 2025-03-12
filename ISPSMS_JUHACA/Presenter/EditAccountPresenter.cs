using ISPSMS_JUHACA.Views.IVews;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views.IVews.ISPSMS_JUHACA.Views.IVews;

namespace ISPSMS_JUHACA.Presenter
{
    public class EditAccountPresenter
    {
        private readonly IEditAccountView _view;
        private readonly IUnitOfWork _unitOfWork;
        private Accounts _account;

        public EditAccountPresenter(IEditAccountView view, IUnitOfWork unitOfWork, Accounts account)
        {
            _view = view;
            _unitOfWork = unitOfWork;
            _account = account;
            LoadAccountData();
        }

        public void LoadAccountData()
        {
            _view.Username = _account.Username;
            _view.AccountName = _account.AccountName;
            _view.Password = _account.AccountPassword;
            _view.ConfirmPassword = _account.AccountPassword;
            _view.AccountRole = _account.AccountRole;
        }

        public void SaveAccount()
        {
            if (_view.Password != _view.ConfirmPassword)
            {
                _view.ShowMessage("Passwords do not match.", "Error");
                return;
            }

            _account.Username = _view.Username;
            _account.AccountName = _view.AccountName;
            _account.AccountPassword = _view.Password;
            _view.ConfirmPassword = _account.AccountPassword;
            _account.AccountRole = _view.AccountRole;

            if (_view.CurrentUserRole == "ADMIN" && (_account.AccountRole == "CEO" || _account.AccountRole == "ADMIN"))
            {
                _view.ShowMessage("You do not have permission to modify this account.", "Access Denied");
                return;
            }

            _unitOfWork.accountsRepository.Update(_account);
            _unitOfWork.Save();
            _view.ShowMessage("Account details saved successfully.", "Success");
            _view.CloseForm();
        }

        public void DeleteAccount()
        {
            _unitOfWork.accountsRepository.Remove(_account);
            _unitOfWork.Save();
            _view.ShowMessage("Account successfully deleted.", "Success");
            _view.CloseForm();
        }
    }
}
