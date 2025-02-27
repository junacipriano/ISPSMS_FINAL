namespace Infastructure.Data.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        IAccountsRepository accountsRepository { get; }
        IActivityRepository activityRepository { get; }
        IConnectedSubscribersRepository connectedSubscriberRepository { get; }
        IDisconnectedSubscribersRepository disconnectedSubscriberRepository { get; }
        ITransactionsRepository transactionsRepository { get; }
        void Save();
    }
}