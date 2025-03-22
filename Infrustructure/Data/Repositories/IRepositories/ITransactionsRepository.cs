using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface ITransactionsRepository : IRepository<Transactions>
    {
        void Update(Transactions obj);
        Task<List<Transactions>> GetAllAsync();
        Task<List<Transactions>> GetPaginatedAsync(int pageNumber, int pageSize, bool orderByDescending);

        Task<int> GetTotalCountAsync();
        Task<decimal> GetTotalPaidAmountAsync();

        Task<List<Transactions>> GetByDateAsync(DateTime date);
    }
}
