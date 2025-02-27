using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Views.USERCONTROL;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public void EditLoad()
        {

            if (_subscribersForm.isEdit && _subscribersForm.ConSubsEntity != null)
            {
            
                string[] nameParts = _subscribersForm.ConSubsEntity.Conn_Name
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (nameParts.Length >= 3)
                {
                    _view.LastName = nameParts[0];
                    _view.FirstName = nameParts[1];
                    _view.MiddleInitial = nameParts[2];
                }
                else if (nameParts.Length == 2)
                {
                    _view.LastName = nameParts[0];
                    _view.FirstName = nameParts[1];
                    _view.MiddleInitial = string.Empty;
                }
                else
                {
                    _view.LastName = _subscribersForm.ConSubsEntity.Conn_Name;
                    _view.FirstName = string.Empty;
                    _view.MiddleInitial = string.Empty;
                }

                // Split the address into District and Barangay
                string[] addressParts = _subscribersForm.ConSubsEntity.Address
                                            .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (addressParts.Length >= 2)
                {
                    _view.District = addressParts[0].Trim();
                    _view.Barangay = addressParts[1].Trim();
                }
                else
                {
                    _view.District = _subscribersForm.ConSubsEntity.Address;
                    _view.Barangay = string.Empty;
                }

                // Assign the remaining fields
                _view.Plan = _subscribersForm.ConSubsEntity.Plan;
                _view.ContactNumber = _subscribersForm.ConSubsEntity.ContactNumber;
                _view.MonthlyCharge = _subscribersForm.ConSubsEntity.MonthlyCharge;
                _view.DueDate = _subscribersForm.ConSubsEntity.CurrentDuedate;
            }
          
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

            _view.ShowMessage("Subscriber successfully added!");
            _subscribersForm.getSubscribers();
            _view.CloseForm();
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
