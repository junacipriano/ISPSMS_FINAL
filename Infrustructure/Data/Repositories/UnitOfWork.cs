using Infastructure.Data.Repositories.IRepositories;
using Infastructure.Repositories;
using ISPSMS_JUHACA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext dbContext;
        public IAccountsRepository accountsRepository { get; private set; }
        public IActivityRepository activityRepository { get; private set; }
        public IConnectedSubscribersRepository connectedSubscriberRepository { get; private set; }
        public IDisconnectedSubscribersRepository disconnectedSubscriberRepository { get; private set; }
        public ITransactionsRepository transactionsRepository { get; private set; }

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            accountsRepository ??= new AccountsRepository(dbContext);
            activityRepository ??= new ActivityRepository(dbContext);
            connectedSubscriberRepository ??= new ConnectedSubscribersRepository(dbContext);
            disconnectedSubscriberRepository ??= new DisconnectedSubscribersRepository(dbContext);
            transactionsRepository ??= new TransactionsRepository(dbContext);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
