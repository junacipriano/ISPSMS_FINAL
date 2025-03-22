using ISPSMS_JUHACA.Views.IVews;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views.IVews.ISPSMS_JUHACA.Views.IVews;
using System;
using ISPSMS_JUHACA.Views;
using BCrypt.Net; // 🔹 Import BCrypt for password hashing

namespace ISPSMS_JUHACA.Presenter
{
    public class EditAccountPresenter
    {
        private readonly IEditAccountView _view;
        private readonly IUnitOfWork _unitOfWork;
        private Accounts _account;
        private readonly string _currentUserName;
        private readonly string _currentUserRole;

        public EditAccountPresenter(IEditAccountView view, IUnitOfWork unitOfWork, Accounts account, string currentUserName, string currentUserRole)
        {
            _view = view;
            _unitOfWork = unitOfWork;
            _account = account;
            _currentUserName = currentUserName;
            _currentUserRole = currentUserRole;
            LoadAccountData();
        }

        public void LoadAccountData()
        {
            _view.ProfileName = _account.AccountName;
            _view.ProfileRole = _account.AccountRole;
            _view.Username = _account.Username;
            _view.AccountName = _account.AccountName;
            _view.AccountRole = _account.AccountRole;
        }

        public void SaveAccount()
        {
            try
            {
                // 🔹 Validate required fields
                if (string.IsNullOrWhiteSpace(_view.Username) || string.IsNullOrWhiteSpace(_view.AccountName))
                {
                    _view.ShowMessage("Username and Account Name cannot be empty.", "Error");
                    return;
                }

                if (string.IsNullOrWhiteSpace(_view.Password))
                {
                    _view.ShowMessage("Password cannot be empty.", "Error");
                    return;
                }

                if (_view.Password != _view.ConfirmPassword)
                {
                    _view.ShowMessage("Passwords do not match.", "Error");
                    return;
                }

                _account.Username = _view.Username;
                _account.AccountName = _view.AccountName;

                // 🔹 Hash the password only if it's changed
                if (!string.IsNullOrWhiteSpace(_view.Password))
                {
                    _account.AccountPassword = BCrypt.Net.BCrypt.HashPassword(_view.Password);
                }

                _account.AccountRole = _view.AccountRole;

                // 🔹 Prevent unauthorized role modification
                if (_view.CurrentUserRole == "ADMIN" && (_account.AccountRole == "CEO" || _account.AccountRole == "ADMIN"))
                {
                    _view.ShowMessage("You do not have permission to modify this account.", "Access Denied");
                    return;
                }

                _unitOfWork.accountsRepository.Update(_account);
                _unitOfWork.Save();

                LogActivity("Edit account: " + _account.Username);

                _view.ShowMessage("Account details saved successfully.", "Success");
                _view.CloseForm();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"An error occurred: {ex.Message}", "Error");
            }
        }

        public void DeleteAccount()
        {
            try
            {
                _unitOfWork.accountsRepository.Remove(_account);
                _unitOfWork.Save();

                LogActivity("Delete account: " + _account.AccountName);

                _view.ShowMessage("Account successfully deleted.", "Success");
                _view.CloseForm();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"An error occurred while deleting the account: {ex.Message}", "Error");
            }
        }

        private void LogActivity(string activityDescription)
        {
            try
            {
                var activity = new Activity
                {
                    AccountName = _currentUserName,
                    AccountRole = _currentUserRole,
                    ActivitiesDone = activityDescription,
                    ActivitiesDateTime = DateTime.Now
                };

                _unitOfWork.activityRepository.Update(activity);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Failed to log activity: {ex.Message}", "Error");
            }
        }
    }
}
