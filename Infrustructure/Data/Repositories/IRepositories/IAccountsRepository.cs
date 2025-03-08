using Domain.Models;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface IAccountsRepository : IRepository<Accounts>
    {
       
        void Update(Accounts obj);
        Accounts GetAccountByEmailAndPassword(string email, string password);
    }
}