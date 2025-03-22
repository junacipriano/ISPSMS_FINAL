using Domain.Models;

namespace Infastructure.Data.Repositories.IRepositories
{
    public interface IConnectedSubscribersRepository : IRepository<ConnectedSubscribers>
    {
        int CountAnahawonSubscribers();
        int CountBasecampSubscribers();
        int CountCamp1Subscribers();
        int CountColambugonSubscribers();
        int CountDanggawanSubscribers();
        int CountDologonSubscribers();
        int CountNorthSubscribers();
        int CountPanadtalanSubscribers();
        int CountSanmiguelSubscribers();
        int CountSouthSubscribers();
        int CountAllSubscriber();
        int CountPastDue();
        int CountOverDue();
        int CountActive();
        int CountDue();
        void Save();
        void Update(ConnectedSubscribers obj);
    }
}