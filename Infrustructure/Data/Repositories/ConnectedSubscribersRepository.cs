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

        public int CountDologonSubscribers()
        {
            return _db.ConnectedSubscribers.Count(s => s.Address.Contains("Dologon"));
        }

        public int CountNorthSubscribers()
        {

            return _db.ConnectedSubscribers.Count(s => s.Address.Contains("North Poblacion"));
        }
        public int CountColambugonSubscribers()
        {

            return _db.ConnectedSubscribers.Count(s => s.Address.Contains("Colambugon"));
        }
        public int CountDanggawanSubscribers()
        {

            return _db.ConnectedSubscribers.Count(s => s.Address.Contains("Danggawan"));
        }
        public int CountSanmiguelSubscribers()
        {

            return _db.ConnectedSubscribers.Count(s => s.Address.Contains("San Miguel"));
        }
        public int CountBasecampSubscribers()
        {

            return _db.ConnectedSubscribers.Count(s => s.Address.Contains("Base Camp"));
        }
        public int CountPanadtalanSubscribers()
        {

            return _db.ConnectedSubscribers.Count(s => s.Address.Contains("Panadtalan"));
        }
        public int CountAnahawonSubscribers()
        {

            return _db.ConnectedSubscribers.Count(s => s.Address.Contains("Anahawon"));
        }
        public int CountSouthSubscribers()
        {

            return _db.ConnectedSubscribers.Count(s => s.Address.Contains("South Poblacion"));
        }
        public int CountCamp1Subscribers()
        {

            return _db.ConnectedSubscribers.Count(s => s.Address.Contains("Camp 1"));
        }

        public int CountAllSubscriber()
        {
            return _db.ConnectedSubscribers.Count();
        }

        public int CountPastDue()
        {
            return _db.ConnectedSubscribers.Count(s => s.Status.Contains("Past Due"));
        }
        public int CountOverDue()
        {
            return _db.ConnectedSubscribers.Count(s => s.Status.Contains("Overdue"));
        }
        public int CountActive()
        {
            return _db.ConnectedSubscribers.Count(s => s.Status.Contains("Active"));
        }

        public int CountDue()
        {
            return CountPastDue()+CountOverDue();
        }
    }
}