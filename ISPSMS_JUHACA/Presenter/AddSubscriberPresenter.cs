using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views.IVews;
using Microsoft.EntityFrameworkCore;
using static Unity.Storage.RegistrationSet;

namespace ISPSMS_JUHACA.Presenter
{
    public class AddSubscriberPresenter
    {
            private readonly IMainSubscriberPage _view;
            private readonly IUnitOfWork _dbContext;
            private readonly MainForm _subscribersForm;

            public AddSubscriberPresenter(IMainSubscriberPage view, IUnitOfWork dbContext, MainForm subscribersForm)
            {
                _view = view;
                _dbContext = dbContext;
                _subscribersForm = subscribersForm;

                _view.SaveSubscriber += OnSaveSubscriber;
            }

        private void OnSaveSubscriber(object? sender, EventArgs e)
        {
            var entity = _subscribersForm.ConSubsEntity;

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

                _dbContext.connectedSubscriberRepository.Add(newSubscriber);
                _dbContext.Save();
                _view.ShowMessage("Subscriber ADDED successfully!"); // ✅ Check if this appears twice
            }

            _subscribersForm.getSubscribers(); // ✅ Refresh UI once

            if (_view is Form addForm)
            {
                addForm.Close(); // ✅ Close form after saving
            }

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
