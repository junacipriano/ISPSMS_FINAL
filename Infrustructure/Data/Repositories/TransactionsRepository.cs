using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;

namespace Infastructure.Data.Repositories
{
    public class TransactionsRepository : Repository<Transactions>, ITransactionsRepository
    {
        private AppDbContext _db;
        public TransactionsRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Transactions obj)
        {
            _db.Transactions.Update(obj);
        }

    }
}
