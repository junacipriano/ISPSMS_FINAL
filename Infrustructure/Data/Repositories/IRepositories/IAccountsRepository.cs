using Domain.Models;
using System.Threading.Tasks;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface IAccountsRepository : IRepository<Accounts>
    {
        void Update(Accounts obj);
        Accounts GetAccountByEmailAndPassword(string email, string password);
        Task<Accounts> GetAccountByEmailAndPasswordAsync(string email, string password); // Add this line
    }
}
