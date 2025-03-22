using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Infastructure.Data.Repositories;
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

        public async Task LoadTransactionsAsync(int pageNumber, int pageSize)
        {

            var transactions = await _dbContext.transactionsRepository.GetPaginatedAsync(pageNumber, pageSize, true); // Always descending
            decimal totalPaidAmount = transactions.Sum(t => t.PaidAmount);
            _view.DisplayTransactions(transactions);
            _view.UpdatePaidAmountLabel(totalPaidAmount);
        }

        public Task<decimal> GetTotalPaidAmountAsync()
        {
            return _dbContext.transactionsRepository.GetTotalPaidAmountAsync();
        }


        public async Task<int> GetTotalPagesAsync(int pageSize)
        {
            int totalCount = await _dbContext.transactionsRepository.GetTotalCountAsync();
            return (int)Math.Ceiling((double)totalCount / pageSize);
        }
        public async Task<List<Transactions>> GetTransactionsByDateAsync(DateTime TransactionDateTime)
        {
            return await _dbContext.transactionsRepository.GetByDateAsync(TransactionDateTime);
        }
    }
}
