using Domain.Models;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface IDisconnectedSubscribersRepository : IRepository<DisconnectedSubscribers>
    {

        void Update(DisconnectedSubscribers obj);
        int CountDisconnected();
    }
} 