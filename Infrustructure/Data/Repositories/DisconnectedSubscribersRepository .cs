using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;

namespace Infastructure.Data.Repositories
{
    public class DisconnectedSubscribersRepository : Repository<DisconnectedSubscribers>, IDisconnectedSubscribersRepository
    {
        private AppDbContext _db;
        public DisconnectedSubscribersRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(DisconnectedSubscribers obj)
        {
            _db.DisconnectedSubscribers.Update(obj);
        }


    }
}
