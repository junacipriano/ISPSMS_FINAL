using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;

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

    }
}
