using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Infastructure.Data.Repositories;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.MainPages;
using ISPSMS_JUHACA.Views.IVews;
using Microsoft.EntityFrameworkCore;
using Activity = Domain.Models.Activity;

namespace ISPSMS_JUHACA.Presenter
{
    public class AddSubscriberPresenter
    {
        private readonly IMainSubscriberPage _view;
        private readonly IUnitOfWork _dbContext;
        private readonly SubscriberPage _subscribersForm;
        private readonly string _currentUsername;
        private readonly string _currentUserRole;
        private MainForm _mainForm;

        private bool isSaving = false;

        public AddSubscriberPresenter(
            IMainSubscriberPage view,
            IUnitOfWork dbContext,
            SubscriberPage subscribersForm,
            string currentUsername,
            MainForm mainForm) // Add MainForm as a parameter
        {
            _view = view;
            _dbContext = dbContext;
            _subscribersForm = subscribersForm;
            _currentUsername = currentUsername;
            _mainForm = mainForm; // Store the MainForm instance

            _currentUsername = _mainForm.GetUsername(); // Get username from MainForm
            _currentUserRole = _mainForm.GetUserRole(); // Get role from MainForm

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

        private static string FormatName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return string.Empty;

            return string.Join(" ", name.Split(' ')
                .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
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
            _view.LastName = nameParts.Length > 0 ? FormatName(nameParts[0]) : "";
            _view.FirstName = nameParts.Length > 1 ? FormatName(nameParts[1]) : "";
            _view.MiddleInitial = nameParts.Length > 2 ? FormatName(nameParts[2]) : "";

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
            if (!ValidateFields()) return;

            _view.LastName = FormatName(_view.LastName);
            _view.FirstName = FormatName(_view.FirstName);
            _view.MiddleInitial = FormatName(_view.MiddleInitial);

            if (_subscribersForm.isEdit)
            {
                var entity = _subscribersForm.BindingSource.Current as ConnectedSubscribers;
                if (entity == null)
                {
                    _view.ShowMessage("Error: No subscriber selected for editing.");
                    return;
                }

                // Store original values before updating
                string oldName = entity.Conn_Name;
                string oldAddress = entity.Address;
                string oldPlan = entity.Plan;
                string oldContact = entity.ContactNumber;
                decimal oldCharge = entity.Charge;
                DateTime oldDueDate = entity.CurrentDuedate;

                // Update values
                entity.Conn_Name = $"{_view.LastName}, {_view.FirstName} {_view.MiddleInitial}";
                entity.Address = $"{_view.District}, {_view.Barangay}";
                entity.Plan = _view.Plan;
                entity.ContactNumber = _view.ContactNumber;
                entity.Charge = _view.MonthlyCharge;

                // Strip the time portion and keep only the date (set to midnight)
                entity.CurrentDuedate = _view.DueDate.Date; // This keeps only the date part (without time)

                entity.Status = "Active";

                _dbContext.connectedSubscriberRepository.Update(entity);
                _dbContext.Save();

                // Build activity log
                List<string> changes = new List<string>();
                if (oldName != entity.Conn_Name) changes.Add($"Name: {oldName} → {entity.Conn_Name}");
                if (oldAddress != entity.Address) changes.Add($"Address: {oldAddress} → {entity.Address}");
                if (oldPlan != entity.Plan) changes.Add($"Plan: {oldPlan} → {entity.Plan}");
                if (oldContact != entity.ContactNumber) changes.Add($"Contact: {oldContact} → {entity.ContactNumber}");
                if (oldCharge != entity.Charge) changes.Add($"Charge: {oldCharge} → {entity.Charge}");
                if (oldDueDate != entity.CurrentDuedate) changes.Add($"Due Date: {oldDueDate:MM/dd/yyyy} → {entity.CurrentDuedate:MM/dd/yyyy}");

                if (changes.Count > 0)
                {
                    string activityDescription = $"Edited Subscriber: {entity.Conn_Name} ({string.Join(", ", changes)})";
                    LogActivity(activityDescription);
                }

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

                    // Add 1 month and keep only the date part (no time)
                    CurrentDuedate = _view.DueDate.AddMonths(1).Date, // Strip time, keep only the date

                    InstallationDate = DateTime.Now.Date,
                    Status = "Active",
                    Balance = 0,
                    MonthlyCharge = _view.MonthlyCharge
                };

                _dbContext.connectedSubscriberRepository.Add(newSubscriber);
                _dbContext.Save();

                // Log the activity
                LogActivity($"Added Subscriber: {newSubscriber.Conn_Name}");

                _view.ShowMessage("Subscriber ADDED successfully!");
            }

            _subscribersForm.getSubscribers();


            _subscribersForm.getSubscribers();
            if (_view is Form addForm) addForm.Close();
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
            if (new[] { _view.LastName, _view.FirstName, _view.District, _view.Barangay, _view.Plan, _view.ContactNumber }.Any(string.IsNullOrWhiteSpace))
            {
                _view.ShowMessage("Please fill in all required fields.");
                return false;
            }

            if (_view.ContactNumber.Length != 11 || !_view.ContactNumber.All(char.IsDigit))
            {
                _view.ShowMessage("Contact number must be exactly 11 digits and contain only numbers.");
                return false;
            }

            return true;
        }

        private static string GetDistrict(string address) => address.Split(',')[0].Trim();
        private static string GetBarangay(string address) => address.Split(',')[1].Trim();

        private void LogActivity(string activityDescription)
        {
            var activity = new Activity
            {
                AccountName = _currentUsername, 
                AccountRole = _currentUserRole, 
                ActivitiesDone = activityDescription,
                ActivitiesDateTime = DateTime.Now
            };

            _dbContext.activityRepository.Update(activity);
            _dbContext.Save();
        }

    }
}
