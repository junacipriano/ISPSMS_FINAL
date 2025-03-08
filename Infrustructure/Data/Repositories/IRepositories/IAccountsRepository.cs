using Domain.Models;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface IAccountsRepository
    {
       
        void Update(Accounts obj);
        void Save();

        Accounts GetAccountByEmailAndPassword(string email, string password);
        IEnumerable<Accounts> GetAll();
        void Remove(Accounts selectedAccount);
    }
}