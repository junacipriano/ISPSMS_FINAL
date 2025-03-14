using System;
using System.Collections.Generic;
using System.Diagnostics;
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


        private bool isSaving = false;
        public AddSubscriberPresenter(IMainSubscriberPage view, IUnitOfWork dbContext, SubscriberPage subscribersForm)
        {
            _view = view;
            _dbContext = dbContext;
            _subscribersForm = subscribersForm;

            _view.BarangayChanged += OnBarangayChanged;

        }

        private void OnBarangayChanged(object? sender, EventArgs e)
        {


            if (_view.Barangay.Equals("Anahawon", StringComparison.OrdinalIgnoreCase))
            {
                _view.DistrictOptions = new List<string> { "Purok2", "Purok 4", "Purok 6", "Purok 7" };
            }
            else if (_view.Barangay.Equals("Base Camp", StringComparison.OrdinalIgnoreCase))
            {
                _view.DistrictOptions = new List<string> { "Purok 1", "Purok 2", "Purok 3", "Purok 3,  NoyNay Village", "Purok 9", "Purok 9, Urban Poor", "Purok 7, Kalagutay" };
            }
            else if (_view.Barangay.Equals("Colambugon", StringComparison.OrdinalIgnoreCase))
            {
                _view.DistrictOptions = new List<string> { "Purok 2", "Purok 3" };
            }
            else if (_view.Barangay.Equals("Danggawan", StringComparison.OrdinalIgnoreCase))
            {
                _view.DistrictOptions = new List<string> { "Purok 1", "Purok 5", "Kalinga" };
            }
            else if (_view.Barangay.Equals("Dologon", StringComparison.OrdinalIgnoreCase))
            {
                _view.DistrictOptions = new List<string> { "Purok 1", "Purok 1A", "Purok 2", "Purok 2A", "Purok 3", "Purok 3A", "Purok 4", "Purok 4A", "Purok 5", "Purok 5A", "Purok 6", "Purok 6A", "Purok 5A, Paglaum Village", "Purok 6A, Talipapa", "Purok 9", "Purok 9,Donhai" };
            }
            else if (_view.Barangay.Equals("Panadtalan", StringComparison.OrdinalIgnoreCase))
            {
                _view.DistrictOptions = new List<string> { "Purok 2B", "Purok 5A, JVO VILLAGE" };
            }
            else if (_view.Barangay.Equals("South Poblacion", StringComparison.OrdinalIgnoreCase))
            {
                _view.DistrictOptions = new List<string>
            {
            "Purok 1", "Purok 1A", "Purok 1B", "Purok 2", "Purok 2, Tamarin St.",
            "Purok 2A, Tamarind St.", "Purok 3", "Purok 3A", "Purok 4", "Purok 4A",
            "Purok 5", "Purok 5A", "Purok 6", "Purok 6A", "Purok 7", "Purok 7A",
            "Purok 8", "Purok 9B", "Purok 9", "Wet Market", "Perimeter", "Purok 10"
             };
            }
            else if (_view.Barangay.Equals("San Miguel", StringComparison.OrdinalIgnoreCase))
            {
                _view.DistrictOptions = new List<string>
            {
            "Purok 1A", "Purok 1B", "Purok 2B", "Purok 3", "Purok 10A",
            "Green Hills", "Purok 10B", "Paglaum Village", "Kalinga Village",
            "Dairy Farm Guard House"
            };
            }
            else if (_view.Barangay.Equals("North Poblacion", StringComparison.OrdinalIgnoreCase))
            {
                _view.DistrictOptions = new List<string>
        {
            "Purok 1", "Purok 1A", "Purok 1, Tuban Village", "Purok 2", "Purok 2A",
            "Purok 2A, Delcho Homes", "Purok 3", "Purok 4", "Purok 5", "Purok 5A",
            "Purok 5A, Teacher's Village", "Purok 6", "Purok 6, Bulangan", "Purok 6A",
            "Purok 7", "Purok 7A", "Purok 8", "Purok 8A", "Purok 9", "Purok 9B", "Southern"
        };
            }

            else
            {
                _view.DistrictOptions = GetAllDistricts();
            }
        }


        private List<string> GetAllDistricts()
        {
            return new List<string>
    {
        "Purok 1",
        "Purok 2",
        "Purok 3",
        "Purok 3, NoyNay Village",
        "Purok 9",
        "Purok 9, Urban Poor",
        "Purok 7, Kalagutay",
        "Purok 4",
        "Purok 5",
        "Purok 6",
        "Purok 7",
        "Purok 10",
        "Purok 1A",
        "Purok 2A",
        "Purok 3A",
        "Purok 4A",
        "Purok 5A",
        "Purok 5A, Paglaum Village",
        "Purok 6A",
        "Purok 6, Talipapa",
        "Purok 9, Donhai",
        "Purok 1, Tuban Village",
        "Purok 2A, Delcho Homes",
        "Purok 5A, Teacher's Village",
        "Purok 6, Bulanagan",
        "Purok 7A",
        "Purok 8A",
        "Purok 8",
        "Purok 9B",
        "Southern",
        "Purok 2B",
        "Purok 5A, JVO VILLAGE",
        "Purok 2B",
        "PUROK 10A, Green Hills",
        "Purok 10B",
        "Paglaum Village",
        "Kalinga Village",
        "Dairy Farm Guard House",
        "Purok 2, Tamarin St.",
        "Purok 2A, Tamarind St.",
        "Wet Market",
        "Perimeter",
        "Kalinga",
        "Purok 1B"
    };
        }


        public void EditLoad()
        {


            var selectedSubscriber = _subscribersForm.BindingSource.Current as ConnectedSubscribers;

            if (selectedSubscriber == null)
            {
                _view.ShowMessage("No subscriber selected.");
                return;
            }


            var nameParts = selectedSubscriber.Conn_Name.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            _view.LastName = nameParts.Length > 0 ? nameParts[0] : "";
            _view.FirstName = nameParts.Length > 1 ? nameParts[1] : "";
            _view.MiddleInitial = nameParts.Length > 2 ? nameParts[2] : "";

            _view.District = GetDistrict(selectedSubscriber.Address);
            _view.Barangay = GetBarangay(selectedSubscriber.Address);
            _view.Plan = selectedSubscriber.Plan;
            _view.ContactNumber = selectedSubscriber.ContactNumber;
            _view.MonthlyCharge = selectedSubscriber.MonthlyCharge;
            _view.DueDate = selectedSubscriber.CurrentDuedate;

            _subscribersForm.isEdit = true;



        }
        public void OnSaveSubscriber()
        {


            if (!ValidateFields())
            {

                return;
            }


            if (_subscribersForm.isEdit)
            {
                var entity = _subscribersForm.BindingSource.Current as ConnectedSubscribers;
                if (entity == null)
                {
                    _view.ShowMessage("Error: No subscriber selected for editing.");
                    return;
                }

                entity.Conn_Name = $"{_view.LastName}, {_view.FirstName} {_view.MiddleInitial}";
                entity.Address = $"{_view.District}, {_view.Barangay}";
                entity.Plan = _view.Plan;
                entity.ContactNumber = _view.ContactNumber;
                entity.Charge = _view.MonthlyCharge;
                entity.CurrentDuedate = _view.DueDate;
                entity.Status = "Active";

                _dbContext.connectedSubscriberRepository.Update(entity);
                _dbContext.Save();


                _view.ShowMessage("Subscriber UPDATED successfully!");

            }
            else
            {
                var newSubscriber = new ConnectedSubscribers
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

                _view.ShowMessage("Subscriber ADDED successfully!");
            }

            _subscribersForm.getSubscribers();

            if (_view is Form addForm)
            {
                addForm.Close();
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
            if (string.IsNullOrWhiteSpace(_view.LastName) ||
                string.IsNullOrWhiteSpace(_view.FirstName) ||
                string.IsNullOrWhiteSpace(_view.District) ||
                string.IsNullOrWhiteSpace(_view.Barangay) ||
                string.IsNullOrWhiteSpace(_view.Plan) ||
                string.IsNullOrWhiteSpace(_view.ContactNumber))
            {
                _view.ShowMessage("Please fill in all required fields.");
                return false;
            }

            if (_view.ContactNumber.Length != 11 || !_view.ContactNumber.All(char.IsDigit))
            {
                _view.ShowMessage("Contact number must be exactly 11 digits and contain only numbers.");
                return false;
            }

            if (!_view.LastName.All(char.IsLetter) || !_view.FirstName.All(char.IsLetter) ||
               (!string.IsNullOrWhiteSpace(_view.MiddleInitial) && !_view.MiddleInitial.All(char.IsLetter)))
            {
                _view.ShowMessage("Last Name, First Name, and Middle Initial must contain only letters.");
                return false;
            }
            return true;
        }

        private string GetDistrict(string address) => address.Split(',')[0].Trim();
        private string GetBarangay(string address) => address.Split(',')[1].Trim();

    }
}
