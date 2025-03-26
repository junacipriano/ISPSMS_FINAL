using System;
using System.Transactions;  // For handling transactions
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;

using ISPSMS_JUHACA.Views.IVews;

namespace ISPSMS_JUHACA.Presenter
{
    public class DisconnectedPresenter
    {
        private readonly IUnitOfWork _dbContext;
        private readonly IDisconnected _view;

        public DisconnectedPresenter(IUnitOfWork dbContext, IDisconnected view)
        {
            _dbContext = dbContext;
            _view = view;
        }

        public void LoadDisconnectedSubscribers()
        {
            var subscribers = _dbContext.disconnectedSubscriberRepository.GetAll();
            _view.SetDisconnectedSubscribers(subscribers);
        }


    }
}
