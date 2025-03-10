using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;
using Microsoft.EntityFrameworkCore;

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
            var existingEntity = _db.ConnectedSubscribers.Local.FirstOrDefault(s => s.subs_id == obj.subs_id);

            if (existingEntity != null)
            {
                _db.Entry(existingEntity).State = EntityState.Detached; // Detach old entity to avoid tracking conflicts
            }

            _db.ConnectedSubscribers.Attach(obj);
            _db.Entry(obj).State = EntityState.Modified; // Mark as modified

        }

        public void Save()
        {
            _db.SaveChanges();
        }


    }
}