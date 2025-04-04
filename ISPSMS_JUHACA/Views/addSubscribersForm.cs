﻿using Domain.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Views.IVews;
using ISPSMS_JUHACA.Presenter;
using ISPSMS_JUHACA.MainPages;
using System.Diagnostics;
using Krypton.Toolkit;

namespace ISPSMS_JUHACA
{
    public partial class addSubscribersForm : KryptonForm, IMainSubscriberPage
    {
        public readonly IUnitOfWork dbContext;
        internal SubscriberPage SubscribersForm;
        private readonly AddSubscriberPresenter _presenter;
        public Domain.Models.ConnectedSubscribers ConSubsEntity;
        internal string message;
        private readonly IMainSubscriberPage _view;

        public event EventHandler SaveSubscriber;
        public event EventHandler FormLoaded;
        public event EventHandler DistrictChanged;
        public event EventHandler BarangayChanged;



        public ConnectedSubscribers EditedSubscriber { get; set; }

        public string LastName
        {
            get => lastNameTextBox.Text.Trim().ToUpper();
            set => lastNameTextBox.Text = value;
        }

        public string FirstName
        {
            get => firstNameTextBox.Text.Trim().ToUpper();
            set => firstNameTextBox.Text = value;
        }

        public string MiddleInitial
        {
            get => MITextBox.Text.Trim().ToUpper();
            set => MITextBox.Text = value;
        }

        public string District
        {
            get => districtComboBox.SelectedItem?.ToString() ?? "";
            set
            {
                districtComboBox.SelectedItem = value;
                DistrictChanged?.Invoke(this, EventArgs.Empty); // Ensure event is triggered
            }
        }

        public string Barangay
        {
            get => barangayComboBox.SelectedItem?.ToString() ?? "";
            set
            {
                barangayComboBox.SelectedItem = value;
                BarangayChanged?.Invoke(this, EventArgs.Empty); // Ensure event is triggered
            }
        }

        public string Plan
        {
            get => planComboBox.Text;
            set => planComboBox.Text = value;
        }

        public string ContactNumber
        {
            get => contactNumberTextBox.Text;
            set => contactNumberTextBox.Text = value;
        }

        public decimal MonthlyCharge
        {
            get => decimal.TryParse(monthlyChargeTextBox.Text, out decimal value) ? value : 0;
            set => monthlyChargeTextBox.Text = value.ToString();
        }

        public DateTime DueDate
        {
            get => dueDatePicker.Value;
            set => dueDatePicker.Value = value;
        }

        public List<string> DistrictOptions
        {
            set
            {
                districtComboBox.BeginUpdate();
                districtComboBox.Items.Clear();
                districtComboBox.Items.AddRange(value.ToArray());

                if (districtComboBox.Items.Count > 0)
                {
                    districtComboBox.SelectedIndex = 0;
                }

                districtComboBox.EndUpdate();
                districtComboBox.Refresh();
            }
        }

        public addSubscribersForm(IUnitOfWork dbContext, SubscriberPage subscribersForm, string currentUsername, string currentUserRole, MainForm mainForm)
        {
            InitializeComponent();
            if (_presenter == null)
            {
                _presenter = new AddSubscriberPresenter(this, dbContext, subscribersForm, currentUsername, mainForm);
            }
            districtComboBox.SelectedIndexChanged += (s, e) =>
            {
                Debug.WriteLine("District changed!");
                DistrictChanged?.Invoke(this, EventArgs.Empty);
            };

            barangayComboBox.SelectedIndexChanged += (s, e) =>
            {
                Debug.WriteLine("Barangay changed!");
                BarangayChanged?.Invoke(this, EventArgs.Empty);
            };
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {

            _presenter.OnSaveSubscriber();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Adding Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CloseForm()
        {
            Hide();
        }

        private void addSubscribersForm_Load(object sender, EventArgs e)
        {
            FormLoaded?.Invoke(this, EventArgs.Empty);



        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
