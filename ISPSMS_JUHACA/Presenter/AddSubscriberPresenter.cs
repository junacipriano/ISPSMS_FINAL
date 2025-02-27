using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Views.USERCONTROL;
using Microsoft.EntityFrameworkCore;

namespace ISPSMS_JUHACA.Presenter
{
    public class AddSubscriberPresenter
    {
            private readonly IMainSubscriberPage _view;
            private readonly IUnitOfWork _dbContext;
            private readonly SubscriberPage _subscribersForm;


        public AddSubscriberPresenter(IMainSubscriberPage view, IUnitOfWork dbContext, SubscriberPage subscribersForm)
            {
                _view = view;
                _dbContext = dbContext;
                _subscribersForm = subscribersForm;

                _view.SaveSubscriber += OnSaveSubscriber;
            }

        private void OnSaveSubscriber(object? sender, EventArgs e)
        {
            var entity = _subscribersForm.BindingSource.Current as ConnectedSubscribers;

            entity = new ConnectedSubscribers
            {
                Conn_Name = $"{_view.LastName}, {_view.FirstName} {_view.MiddleInitial}",
                Address = $"{_view.District}, {_view.Barangay}",
                Plan = _view.Plan,
                Duedate = GetOrdinal(_view.DueDate.Day),
                Charge = _view.MonthlyCharge,
                ContactNumber = _view.ContactNumber,
                CurrentDuedate = _view.DueDate,
                InstallationDate = DateTime.Now,
                Status = "Active",
                Balance = 0,
                MonthlyCharge = _view.MonthlyCharge
            };

            _dbContext.connectedSubscriberRepository.Add(entity);
            _dbContext.Save();

            _view.ShowMessage("Subscriber successfully added!");
            _subscribersForm.getSubscribers();
            _view.CloseForm();
        }

        private string GetOrdinal(int day)
        {
            if (day % 100 is 11 or 12 or 13)
                return day + "th";

            return (day % 10) switch
            {
                1 => day + "st",
                2 => day + "nd",
                3 => day + "rd",
                _ => day + "th",
            };
        }
    }
}
