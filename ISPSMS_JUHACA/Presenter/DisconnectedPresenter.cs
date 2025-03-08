using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infastructure.Data.Repositories;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views;
using ISPSMS_JUHACA.Views.IVews;

namespace ISPSMS_JUHACA.Presenter
{
    public class DisconnectedPresenter
    {
        private IUnitOfWork dbContext;

        private readonly IDisconnected _view;

        public DisconnectedPresenter(IUnitOfWork dbContext, IDisconnected view)
        {
            this.dbContext = dbContext;
            _view = view;
        }
        public void LoadDisconnectedSubscribers()
        {
            var subscribers = dbContext.disconnectedSubscriberRepository.GetAll();
            _view.SetDisconnectedSubscribers(subscribers);
        }
    }
}