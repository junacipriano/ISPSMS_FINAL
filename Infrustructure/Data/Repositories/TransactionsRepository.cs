using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Data.Repositories
{
    public class TransactionsRepository : Repository<Transactions>, ITransactionsRepository
    {
        private readonly AppDbContext _context;

        public TransactionsRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Transactions obj)
        {
            _context.Transactions.Update(obj);
        }

        public async Task<IEnumerable<Transactions>> GetAllAsync()
        {
            var transactions = await _context.Transactions
                .AsNoTracking()
                .ToListAsync();

            return transactions.AsEnumerable(); // Return as IEnumerable
        }

        public async Task<IEnumerable<Transactions>> GetPaginatedAsync(int pageNumber, int pageSize, bool orderByDescending = false)
        {
            // Fetch all transactions into memory (IEnumerable)
            var allTransactions = await GetAllAsync();

            // Apply ordering in-memory
            IEnumerable<Transactions> orderedTransactions;
            if (orderByDescending)
            {
                orderedTransactions = allTransactions.OrderByDescending(t => t.TransactionDateTime);
            }
            else
            {
                orderedTransactions = allTransactions.OrderBy(t => t.TransactionDateTime);
            }

            // Apply paging in-memory
            return orderedTransactions.Skip((pageNumber - 1) * pageSize)
                                       .Take(pageSize);
        }
          public async Task<decimal> GetTotalPaidAmountAsync()
        {
            return await _context.Transactions.SumAsync(t => (decimal?)t.PaidAmount) ?? 0;
        }

        // Get the total count of transactions (same as before)


        public async Task<int> GetTotalCountAsync()
        {
            return await _context.Transactions.AsNoTracking().CountAsync();
        }
        public async Task<IEnumerable<Transactions>> GetByDateAsync(DateTime TransactionDateTime)
        {
            var transactions = await _context.Transactions
                .Where(t => t.TransactionDateTime.Date == TransactionDateTime.Date)
                .ToListAsync();

            return transactions.AsEnumerable();
        }

        public async Task<IEnumerable<(DateTime Date, decimal TotalAmount)>> GetDailyTransactionTotalsAsync()
        {
            var dailyTotals = await _context.Transactions
                .GroupBy(t => t.TransactionDateTime.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    TotalAmount = g.Sum(t => t.PaidAmount)
                })
                .ToListAsync();

            return dailyTotals.Select(d => (d.Date, d.TotalAmount));
        }



        public float AnahawonTotalPaidAmount()
        {
            return (float)_context.Transactions
                .Where(t => t.Address.Contains("Anahawon"))
                .Sum(t => t.PaidAmount);
        }
        public float ColambugonTotalPaidAmount()
        {
            return (float)_context.Transactions
                .Where(t => t.Address.Contains("Colambugon"))
                .Sum(t => t.PaidAmount);
        }
        public float DanggawanTotalPaidAmount()
        {
            return (float)_context.Transactions
                .Where(t => t.Address.Contains("Danggawan"))
                .Sum(t => t.PaidAmount);
        }
        public float SanMiguelTotalPaidAmount()
        {
            return (float)_context.Transactions
                .Where(t => t.Address.Contains("San Miguel"))
                .Sum(t => t.PaidAmount);
        }
        public float BaseCampTotalPaidAmount()
        {
            return (float)_context.Transactions
                .Where(t => t.Address.Contains("Base Camp"))
                .Sum(t => t.PaidAmount);
        }
        public float PanadtalanTotalPaidAmount()
        {
            return (float)_context.Transactions
                .Where(t => t.Address.Contains("Panadtalan"))
                .Sum(t => t.PaidAmount);
        }
        public float NorthTotalPaidAmount()
        {
            return (float)_context.Transactions
                .Where(t => t.Address.Contains("North Poblacion"))
                .Sum(t => t.PaidAmount);
        }
        public float SouthTotalPaidAmount()
        {
            return (float)_context.Transactions
                .Where(t => t.Address.Contains("South Poblacion"))
                .Sum(t => t.PaidAmount);
        }
        public float Camp1TotalPaidAmount()
        {
            return (float)_context.Transactions
                .Where(t => t.Address.Contains("Camp 1"))
                .Sum(t => t.PaidAmount);
        }
        public float DologonTotalPaidAmount()
        {
            return (float)_context.Transactions
                .Where(t => t.Address.Contains("Dologon"))
                .Sum(t => t.PaidAmount);
        }
    }
}


      

        

