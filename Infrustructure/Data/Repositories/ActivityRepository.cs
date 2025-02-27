using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;

namespace Infastructure.Data.Repositories
{
    public class ActivityRepository : Repository<Activity>, IActivityRepository
    {
        private AppDbContext _db;
        public ActivityRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Activity obj)
        {
            _db.Activity.Update(obj);
        }
    }
}
