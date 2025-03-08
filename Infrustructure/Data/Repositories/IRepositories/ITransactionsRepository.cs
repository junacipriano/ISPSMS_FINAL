using Domain.Models;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface ITransactionsRepository : IRepository<Transactions>
    {
        
        void Update(Transactions obj);
    }
}