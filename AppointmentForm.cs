using C969.Models;
using C969.Models;
using C969.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
    public partial class AppointmentForm : Form
    {
        private readonly User _currentUser;
        private readonly Appointment _editingAppointment;

        public AppointmentForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            LoadCustomersIntoCombo();
            LoadTypesIntoCombo();
        }

        public AppointmentForm(User currentUser, Appointment appt) : this(currentUser)
        {
            _editingAppointment = appt;
            PrefillFields(appt);
        }

        private void LoadCustomersIntoCombo()
        {
            var custRepo = new CustomerRepository();
            var customers = custRepo.GetAll();

            comboBoxCustomer.DataSource = customers;
            comboBoxCustomer.DisplayMember = "CustomerName";
            comboBoxCustomer.ValueMember = "CustomerId";
        }

        private void LoadTypesIntoCombo()
        {
            comboBoxType.Items.Clear();
            comboBoxType.Items.Add("Planning");
            comboBoxType.Items.Add("Review");
            comboBoxType.Items.Add("Consultation");
            comboBoxType.Items.Add("Follow-up");
            comboBoxType.SelectedIndex = 0;
        }

        private void PrefillFields(Appointment a)
        {
            comboBoxCustomer.SelectedValue = a.CustomerID;
            comboBoxType.SelectedItem = a.Type;
            textBoxTitle.Text = a.Title;
            textBoxDescription.Text = a.Description;
            textBoxLocation.Text = a.Location;
            textBoxContact.Text = a.Contact;
            textBoxUrl.Text = a.Url;

            var localStart = TimeZoneInfo.ConvertTimeFromUtc(a.StartUtc, TimeZoneInfo.Local);
            var localEnd = TimeZoneInfo.ConvertTimeFromUtc(a.EndUtc, TimeZoneInfo.Local);

            dateTimePickerStart.Value = localStart;
            dateTimePickerEnd.Value = localEnd;
        }

        private bool IsWithinBusinessHours(DateTime localStart, DateTime localEnd)
        {
            var eastern = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            DateTime startUtc = TimeZoneInfo.ConvertTimeToUtc(localStart, TimeZoneInfo.Local);
            DateTime endUtc = TimeZoneInfo.ConvertTimeToUtc(localEnd, TimeZoneInfo.Local);

            DateTime startEastern = TimeZoneInfo.ConvertTimeFromUtc(startUtc, eastern);
            DateTime endEastern = TimeZoneInfo.ConvertTimeFromUtc(endUtc, eastern);

            if (startEastern.DayOfWeek < DayOfWeek.Monday || startEastern.DayOfWeek > DayOfWeek.Friday)
                return false;

            var open = new TimeSpan(9, 0, 0);
            var close = new TimeSpan(17, 0, 0);

            if (startEastern.TimeOfDay < open) return false;
            if (endEastern.TimeOfDay > close) return false;

            return true;
        }
        private bool HasOverlap(DateTime localStart, DateTime localEnd, int? editingID)
        {
            DateTime startUtc = TimeZoneInfo.ConvertTimeToUtc(localStart, TimeZoneInfo.Local);
            DateTime endUtc = TimeZoneInfo.ConvertTimeToUtc(localEnd, TimeZoneInfo.Local);

            var repo = new AppointmentRepository();
            var overlapping = repo.GetOverlappingForUser(_currentUser.UserId, startUtc, endUtc, editingID);

            return overlapping.Any();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedItem == null)
            {
                MessageBox.Show("Select a customer.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("Title is required.");
                return;
            }

            DateTime localStart = dateTimePickerStart.Value;
            DateTime localEnd = dateTimePickerEnd.Value;

            if (localEnd <= localStart)
            {
                MessageBox.Show("End time must be after start time.");
                return;
            }

            if (!IsWithinBusinessHours(localStart, localEnd))
            {
                MessageBox.Show("Appointment must be between 9:00 AM and 5:00 PM EST, Monday–Friday.");
                return;
            }

            int? editingId = _editingAppointment?.AppointmentID;

            if (HasOverlap(localStart, localEnd, editingId))
            {
                MessageBox.Show("This appointment overlaps with another appointment for this user.");
                return;
            }

            // convert to UTC for DB
            DateTime startUtc = TimeZoneInfo.ConvertTimeToUtc(localStart, TimeZoneInfo.Local);
            DateTime endUtc = TimeZoneInfo.ConvertTimeToUtc(localEnd, TimeZoneInfo.Local);

            int customerId = (int)comboBoxCustomer.SelectedValue;
            string type = comboBoxType.SelectedItem?.ToString() ?? "";

            try
            {
                var repo = new AppointmentRepository();

                if (_editingAppointment == null)
                {
                    // ADD
                    var a = new Appointment
                    {
                        CustomerID = customerId,
                        UserID = _currentUser.UserId,
                        Title = textBoxTitle.Text.Trim(),
                        Description = textBoxDescription.Text.Trim(),
                        Location = textBoxLocation.Text.Trim(),
                        Contact = textBoxContact.Text.Trim(),
                        Type = type,
                        Url = textBoxUrl.Text.Trim(),
                        StartUtc = startUtc,
                        EndUtc = endUtc
                    };

                    repo.Add(a);
                    MessageBox.Show("Appointment added.");
                }
                else
                {
                    // EDIT
                    _editingAppointment.CustomerID = customerId;
                    _editingAppointment.Title = textBoxTitle.Text.Trim();
                    _editingAppointment.Description = textBoxDescription.Text.Trim();
                    _editingAppointment.Location = textBoxLocation.Text.Trim();
                    _editingAppointment.Contact = textBoxContact.Text.Trim();
                    _editingAppointment.Type = type;
                    _editingAppointment.Url = textBoxUrl.Text.Trim();
                    _editingAppointment.StartUtc = startUtc;
                    _editingAppointment.EndUtc = endUtc;

                    repo.Update(_editingAppointment);
                    MessageBox.Show("Appointment updated.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error while saving appointment: " + ex.Message);
            }
        }
    }
}
