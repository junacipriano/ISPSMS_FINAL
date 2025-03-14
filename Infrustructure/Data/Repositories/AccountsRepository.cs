using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Data.Repositories
{
    public class AccountsRepository : Repository<Accounts>, IAccountsRepository
    {
        private AppDbContext _context;
        public AccountsRepository(AppDbContext db) : base(db)
        {
            _context = db;
        }

        public void Update(Accounts obj)
        {
            var trackedEntity = _context.Accounts.Local.FirstOrDefault(e => e.account_id == obj.account_id);
            if (trackedEntity != null)
            {
                _context.Entry(trackedEntity).State = EntityState.Detached;
            }
            _context.Accounts.Update(obj);
        }

        public Accounts GetAccountByEmailAndPassword(string email, string password)
        {
            return _context.Accounts.FirstOrDefault(a => a.Username == email && a.AccountPassword == password);
        }

        public async Task<Accounts> GetAccountByEmailAndPasswordAsync(string email, string password)
        {
            return await _context.Accounts.FirstOrDefaultAsync(a => a.Username == email && a.AccountPassword == password);
        }
    }
}
