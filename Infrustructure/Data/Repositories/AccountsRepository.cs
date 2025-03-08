using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Data.Repositories
{
    public class AccountsRepository : Repository<Accounts>, IAccountsRepository
    {
        private AppDbContext _db;
        public AccountsRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Accounts obj)
        {
            _db.Accounts.Update(obj);
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public Accounts GetAccountByEmailAndPassword(string email, string password)
        {
            return _db.Accounts.FirstOrDefault(a => a.Username == email && a.AccountPassword == password);
        }
        public IEnumerable<Accounts> GetAll()
        {
            return _db.Accounts.ToList();
        }

    }
}
