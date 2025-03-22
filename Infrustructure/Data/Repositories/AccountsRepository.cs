using System;
using System.Linq;
using System.Threading.Tasks;
using BCrypt.Net;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Data.Repositories
{
    public class AccountsRepository : Repository<Accounts>, IAccountsRepository
    {
        private readonly AppDbContext _context;

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

        public async Task<Accounts> GetAccountByEmailAndPasswordAsync(string email, string password)
        {
            var account = await _context.Accounts.FirstOrDefaultAsync(a => a.Username == email);
            if (account != null && BCrypt.Net.BCrypt.Verify(password, account.AccountPassword))
            {
                return account; // Password matches
            }
            return null; // Invalid credentials
        }
    }
}
