using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views;
using ISPSMS_JUHACA.Views.IVews;
using System;

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
            var account = await Task.Run(() => _repository.GetAccountByEmailAndPassword(_view.Username, _view.AccountPassword));
            if (account != null)
            {
                _view.ShowMessage("Login successful!");
                _view.CloseForm(); // Close the login form first
                var mainForm = new MainForm(_dbContext);
                mainForm.Show(); // Show the main form after closing the login form
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