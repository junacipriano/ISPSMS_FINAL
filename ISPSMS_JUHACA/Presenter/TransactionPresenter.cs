using System;
using System.Collections.Generic;
using System.Linq;
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
        private int _currentPage = 1;
        private const int PageSize = 30;
        private int _totalPages = 1;
        private bool _isLoading = false;
        private int _currentDatePage = 1;
        private int _totalDatePages = 1;
        private int _totalDateItems = 0;
        private const int DatePageSize = 30;
        private int _totalItems = 0;
        private DateTime _selectedDate;


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

        public async Task<List<Transactions>> LoadAllTransactionDataAsync()
        {
            List<Transactions> transactions = (await _dbContext.transactionsRepository
                .GetPaginatedAsync(_currentPage, PageSize, true)).ToList();

            decimal totalPaidAmount = await GetTotalPaidAmountAsync();
            _totalItems = await _dbContext.transactionsRepository.GetTotalCountAsync();
            _totalPages = (int)Math.Ceiling((double)_totalItems / PageSize);

            _view.DisplayTransactions(transactions);
            _view.UpdatePaidAmountLabel(totalPaidAmount);
            _view.SetPaginationButtons(_currentPage > 1, _currentPage < _totalPages);
            UpdatePaginationStatus(_currentPage, PageSize, _totalItems);

            return transactions;
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

        public async Task<List<Transactions>> LoadTransactionsByDateAsync(DateTime transactionDateTime)
        {
            List<Transactions> transactions = (await _dbContext.transactionsRepository.GetByDateAsync(transactionDateTime)).ToList();
            _view.DisplayTransactions(transactions);

            return transactions;
        }
        public async Task<IEnumerable<(DateTime Date, decimal TotalAmount)>> GetDailyTotalsAsync()
        {
            return await _dbContext.transactionsRepository.GetDailyTransactionTotalsAsync();
        }
        private void UpdatePaginationStatus(int currentPage, int pageSize, int totalItems)
        {
            int start = ((currentPage - 1) * pageSize) + 1;
            int end = Math.Min(start + pageSize - 1, totalItems);
            _view.SetPaginationData(currentPage, pageSize, totalItems);
            _view.SetPaginationStatusText($"{start}-{end} of {totalItems}");
        }


    }
}