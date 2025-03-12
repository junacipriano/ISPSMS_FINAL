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
            var trackedEntity = _db.Accounts.Local.FirstOrDefault(e => e.account_id == obj.account_id);
            if (trackedEntity != null)
            {
                _db.Entry(trackedEntity).State = EntityState.Detached;
            }
            _db.Accounts.Update(obj);
        }

        public Accounts GetAccountByEmailAndPassword(string email, string password)
        {
            return _db.Accounts.FirstOrDefault(a => a.Username == email && a.AccountPassword == password);
        }

    }
}
