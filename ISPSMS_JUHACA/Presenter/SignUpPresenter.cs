using System;
using BCrypt.Net;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views;
using ISPSMS_JUHACA.Views.IVews;

namespace ISPSMS_JUHACA.Presenter
{
    public class SignUpPresenter
    {
        private readonly ISignUp _view;
        private readonly IUnitOfWork _dbContext;
        private readonly IAccountsRepository _repository;
  

        public SignUpPresenter(ISignUp view, IUnitOfWork dbContext, IAccountsRepository repository)
        {
            _view = view;
            _dbContext = dbContext;
            _repository = repository;

            _view.Save += OnSaveUser;
        }

        private void OnSaveUser(object? sender, EventArgs e)
        {
            try
            {
                // Hash password using bcrypt
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(_view.AccountPassword);

                var account = new Accounts
                {
                    Username = _view.Username,
                    AccountName = _view.AccountName,
                    AccountPassword = hashedPassword, // Store bcrypt hashed password
                    AccountRole = _view.AccountRole
                };

                _repository.Update(account);
                _dbContext.Save();
                _view.ShowMessage("Account created successfully.");
                _view.ClearFields();
            }
            catch (Exception ex)
            {
                _view.ShowError($"An error occurred: {ex.Message}");
            }
        }

    }
}
