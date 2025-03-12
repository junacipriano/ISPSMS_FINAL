using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views.IVews;

namespace ISPSMS_JUHACA.Presenter
{
    public class TransactionPresenter
    {
        private readonly ITransactionView _view;
        private readonly IUnitOfWork _dbContext;

        public TransactionPresenter(ITransactionView view, IUnitOfWork dbContext)
        {
            _view = view;
            _dbContext = dbContext;
        }

        public void LoadTransactions()
        {
            var transactions = _dbContext.transactionsRepository.GetAll()
                .OrderByDescending(t => t.TransactionDateTime)
                .ToList();

            _view.DisplayTransactions(transactions);
        }
    }
}