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

        public async Task<List<Transactions>> GetAllAsync()
        {
            return await _context.Transactions.AsNoTracking().ToListAsync();
        }

        public async Task<List<Transactions>> GetPaginatedAsync(int pageNumber, int pageSize, bool orderByDescending = false)
        {
            IQueryable<Transactions> query = _context.Transactions.AsNoTracking(); // Prevent EF from tracking queries

            if (orderByDescending)
            {
                query = query.OrderByDescending(t => t.TransactionDateTime);
            }
            else
            {
                query = query.OrderBy(t => t.TransactionDateTime);
            }

            return await query.Skip((pageNumber - 1) * pageSize)
                              .Take(pageSize)
                              .ToListAsync();
        }
        public async Task<decimal> GetTotalPaidAmountAsync()
        {
            return await _context.Transactions.SumAsync(t => (decimal?)t.PaidAmount) ?? 0;
        }

        public async Task<int> GetTotalCountAsync()
        {
            return await _context.Transactions.CountAsync(); // Return total number of transactions
        }
        public async Task<List<Transactions>> GetByDateAsync(DateTime TransactionDateTime)
        {
            return await _context.Transactions
                .Where(t => t.TransactionDateTime.Date == TransactionDateTime)
                .ToListAsync();
        }
    }
}
