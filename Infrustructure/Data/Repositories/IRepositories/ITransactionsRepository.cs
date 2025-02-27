using Domain.Models;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface ITransactionsRepository
    {
        
        void Update(Transactions obj);
    }
}