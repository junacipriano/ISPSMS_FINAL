using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views.IVews;

namespace ISPSMS_JUHACA.Presenter
{
    public class TransactionPresenter
    {
        private readonly ITransactionView _view;
        private readonly IUnitOfWork _dbContext;
        private int _currentPage = 1;
        private const int PageSize = 20;
        private int _totalPages = 1;
        private bool _isLoading = false;

        public TransactionPresenter(ITransactionView view, IUnitOfWork dbContext)
        {
            _view = view;
            _dbContext = dbContext;
        }

        public async Task LoadTransactionsPageAsync(bool nextPage = true)
        {
            if (_isLoading) return;
            _isLoading = true;

            if (nextPage && _currentPage < _totalPages)
            {
                _currentPage++;
            }
            else if (!nextPage && _currentPage > 1)
            {
                _currentPage--;
            }

            await LoadAllTransactionDataAsync();
            _isLoading = false;
        }

        public async Task LoadAllTransactionDataAsync()
        {
            // Fetch transactions for the current page
            IEnumerable<Transactions> transactions = await _dbContext.transactionsRepository.GetPaginatedAsync(_currentPage, PageSize, true);

            // Get total paid amount from the database instead of summing in-memory
            decimal totalPaidAmount = await GetTotalPaidAmountAsync();

            // Get total pages count
            _totalPages = await GetTotalPagesAsync();

            // Update view
            _view.DisplayTransactions(transactions);
            _view.UpdatePaidAmountLabel(totalPaidAmount);
            _view.SetPaginationButtons(_currentPage > 1, _currentPage < _totalPages);
        }

        public Task<decimal> GetTotalPaidAmountAsync()
        {
            return _dbContext.transactionsRepository.GetTotalPaidAmountAsync();
        }

        public async Task<int> GetTotalPagesAsync()
        {
            int totalCount = await _dbContext.transactionsRepository.GetTotalCountAsync();
            return (int)Math.Ceiling((double)totalCount / PageSize);
        }

        public async Task LoadTransactionsByDateAsync(DateTime transactionDateTime)
        {
            var transactions = await _dbContext.transactionsRepository.GetByDateAsync(transactionDateTime);
            _view.DisplayTransactions(transactions);
        }


    }
}