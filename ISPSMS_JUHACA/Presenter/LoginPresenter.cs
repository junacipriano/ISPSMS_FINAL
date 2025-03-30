using System;
using System.Threading.Tasks;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views;
using ISPSMS_JUHACA.Views.IVews;

namespace ISPSMS_JUHACA.Presenter
{
    public class LoginPresenter
    {
        private readonly ILogin _view;
        private readonly IUnitOfWork _dbContext;
        private readonly IAccountsRepository _repository;

        public LoginPresenter(ILogin view, IUnitOfWork dbContext, IAccountsRepository repository)
        {
            _view = view;
            _dbContext = dbContext;
            _repository = repository;

            _view.Login += async (sender, e) => await OnLoginAsync(sender, e);
            _view.SignUp += OnSignUp;
        }

        private async Task OnLoginAsync(object? sender, EventArgs e)
        {
            var account = await _repository.GetAccountByEmailAndPasswordAsync(_view.Username, _view.AccountPassword);
            if (account != null)
            {
                if (account.AccountRole == "DEFAULT")
                {
                    _view.ShowMessage("Your account is not approved yet. Please contact the administrator.");
                    return;
                }

                _view.CloseForm();

                var mainForm = new MainForm(_dbContext);
                mainForm.SetUserProfile(account.AccountName, account.AccountRole, account.AccountPassword, account.Username, account.account_id.ToString());
                mainForm.Show();
                mainForm.OpenSubscribersPage();


            }
            else
            {
                _view.ShowMessage("Invalid email or password.");
            }
        }

        private void OnSignUp(object? sender, EventArgs e)
        {
            var signUpForm = new SignUpForm(_dbContext, _repository);
            signUpForm.Show();
        }
    }
}
