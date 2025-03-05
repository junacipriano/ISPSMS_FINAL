using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.MainPages;
using ISPSMS_JUHACA.Views.IVews;
using Microsoft.EntityFrameworkCore;

namespace ISPSMS_JUHACA.Presenter
{
    public class AddSubscriberPresenter
    {   
            private readonly IMainSubscriberPage _view;
            private readonly IUnitOfWork _dbContext;
            private readonly SubscriberPage _subscribersForm;
            private readonly addSubscribersForm _subscriberForm;

            public AddSubscriberPresenter(IMainSubscriberPage view, IUnitOfWork dbContext, SubscriberPage subscribersForm)
            {
                _view = view;
                _dbContext = dbContext;
                _subscribersForm = subscribersForm;

                _view.SaveSubscriber += OnSaveSubscriber;
            }

        public void EditLoad()
        {


            var selectedSubscriber = _subscribersForm.BindingSource.Current as ConnectedSubscribers;

            if (selectedSubscriber == null)
            {
                _view.ShowMessage("No subscriber selected.");
                return;
            }

            // Split Conn_Name into Last Name, First Name, and Middle Initial
            var nameParts = selectedSubscriber.Conn_Name.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            _view.LastName = nameParts.Length > 0 ? nameParts[0] : ""; // Last Name (before the comma)
            _view.FirstName = nameParts.Length > 1 ? nameParts[1] : ""; // First Name (after comma)
            _view.MiddleInitial = nameParts.Length > 2 ? nameParts[2] : ""; // Middle Initial (if exists)

            _view.District = GetDistrict(selectedSubscriber.Address);
            _view.Barangay = GetBarangay(selectedSubscriber.Address);
            _view.Plan = selectedSubscriber.Plan;
            _view.ContactNumber = selectedSubscriber.ContactNumber;
            _view.MonthlyCharge = selectedSubscriber.MonthlyCharge;
            _view.DueDate = selectedSubscriber.CurrentDuedate;

            _subscribersForm.isEdit = true;



        }
        private void OnSaveSubscriber(object? sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                _view.ShowMessage("Please fill in all required fields.");
                return;
            }

            var entity = _subscribersForm.BindingSource.Current as ConnectedSubscribers;

            if (_subscribersForm.isEdit)
            {
                entity.Conn_Name = _view.LastName;
                entity.Conn_Name += " " + _view.FirstName;
                entity.Conn_Name += " " + _view.MiddleInitial;




                entity.Address = $"{_view.District}, {_view.Barangay}";
                entity.Plan = _view.Plan;
                entity.ContactNumber = _view.ContactNumber;
                entity.Charge = _view.MonthlyCharge;
                entity.ContactNumber = _view.ContactNumber;
                entity.CurrentDuedate = _view.DueDate;
                entity.InstallationDate = DateTime.Now;
                entity.Status = "Active";
                entity.Balance = 0;
                entity.MonthlyCharge = _view.MonthlyCharge;

                _dbContext.connectedSubscriberRepository.Update(entity);
            }
            else
            {
                entity = new Domain.Models.ConnectedSubscribers
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

            }
            _dbContext.Save();
            _subscribersForm.getSubscribers();
            _view.ShowMessage("Subscriber successfully added!");

            if (_view is Form addForm)
            {
                addForm.Close(); // Closes the form after saving
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

        private bool ValidateFields()
        {
            return !(string.IsNullOrWhiteSpace(_view.LastName) ||
                     string.IsNullOrWhiteSpace(_view.FirstName) ||
                     string.IsNullOrWhiteSpace(_view.District) ||
                     string.IsNullOrWhiteSpace(_view.Barangay) ||
                     string.IsNullOrWhiteSpace(_view.Plan) ||
                     string.IsNullOrWhiteSpace(_view.ContactNumber));
        }
        private string GetLastName(string fullName) => fullName.Split(',')[0].Trim();
        private string GetFirstName(string fullName) => fullName.Split(' ')[1].Trim();
        private string GetMiddleInitial(string fullName) => fullName.Split(' ').Length > 2 ? fullName.Split(' ')[2].Trim() : "";
        private string GetDistrict(string address) => address.Split(',')[0].Trim();
        private string GetBarangay(string address) => address.Split(',')[1].Trim();

    }
}
