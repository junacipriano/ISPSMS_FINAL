using Domain.Models;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface IDisconnectedSubscribersRepository
    {
     
        void Update(DisconnectedSubscribers obj);
    }
}