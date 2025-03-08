using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using Infastructure.Data.Repositories;
using ISPSMS_JUHACA.Views.IVews;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                var account = new Accounts
                {
                    Username = _view.Username,
                    AccountName = _view.AccountName,
                    AccountPassword = _view.AccountPassword,
                    AccountRole = _view.AccountRole
                };

                _repository.Update(account);
                _dbContext.Save();
                _view.ShowMessage("Account created successfully.");
            }
            catch (Exception ex)
            {
                _view.ShowError($"An error occurred: {ex.Message}");
            }
        }
    }
}
