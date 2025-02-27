using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;

namespace Infastructure.Repositories
{
    public class ConnectedSubscribersRepository : Repository<ConnectedSubscribers>, IConnectedSubscribersRepository
    {
        private AppDbContext _db;
        public ConnectedSubscribersRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ConnectedSubscribers obj)
        {
            _db.ConnectedSubscribers.Update(obj);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
