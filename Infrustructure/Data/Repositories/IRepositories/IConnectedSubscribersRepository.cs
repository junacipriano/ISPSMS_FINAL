using Domain.Models;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface IConnectedSubscribersRepository : IRepository<ConnectedSubscribers>
    {
        void Update(ConnectedSubscribers obj);

        void Save();

    }
}