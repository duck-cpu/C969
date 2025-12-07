using C969.Models;
using C969.Repositories;
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
    public partial class MainForm : Form
    {
        private User? _currentUser;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(User user) : this()
        {
            _currentUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadAppointments();

            //load todays appointments on calendar
            LoadCalendarForDate(DateTime.Now);
        }
        private void LoadCustomers()
        {
            dataGridCustomers.DataSource = new CustomerRepository().GetAll();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadCustomers();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridCustomers.CurrentRow == null)
                return;

            var customer = (Customer)dataGridCustomers.CurrentRow.DataBoundItem;

            var form = new CustomerForm(customer);
            if (form.ShowDialog() == DialogResult.OK)
                LoadCustomers();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridCustomers.CurrentRow == null)
                return;

            var customer = (Customer)dataGridCustomers.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Delete customer?", "CONFIRM",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var repo = new CustomerRepository();
                    repo.Delete(customer.CustomerID);
                    MessageBox.Show("Customer deleted.");
                    LoadCustomers();
                    LoadAppointments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message);
                }
            }
        }

        private void tabAppointments_Click(object sender, EventArgs e)
        {

        }

        private void LoadAppointments()
        {
            var repo = new AppointmentRepository();
            var appts = repo.GetAll();

            var view = appts.Select(a => new
            {
                a.AppointmentID,
                a.CustomerName,
                a.UserName,
                a.Title,
                a.Type,
                Start = TimeZoneInfo.ConvertTimeFromUtc(a.StartUtc, TimeZoneInfo.Local),
                End = TimeZoneInfo.ConvertTimeFromUtc(a.EndUtc, TimeZoneInfo.Local)
            }).ToList();

            dataGridViewAppointments.DataSource = view;
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            var form = new AppointmentForm(_currentUser);
            if (form.ShowDialog() == DialogResult.OK)
                LoadAppointments();
        }

        private void buttonEditAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.CurrentRow == null)
                return;

            int apptId = (int)dataGridViewAppointments.CurrentRow.Cells["AppointmentId"].Value;

            var repo = new AppointmentRepository();
            var fullList = repo.GetAll();
            var appt = fullList.First(a => a.AppointmentID == apptId);

            var form = new AppointmentForm(_currentUser, appt);
            if (form.ShowDialog() == DialogResult.OK)
                LoadAppointments();
        }

        private void buttonDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.CurrentRow == null)
                return;

            int apptId = (int)dataGridViewAppointments.CurrentRow.Cells["AppointmentId"].Value;

            if (MessageBox.Show("Delete appointment?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var repo = new AppointmentRepository();
                    repo.Delete(apptId);
                    MessageBox.Show("Appointment deleted.");
                    LoadAppointments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting appointment: " + ex.Message);
                }
            }
        }

        private void monthCalendarAppointments_DateSelected(object sender, DateRangeEventArgs e)
        {
            LoadCalendarForDate(e.Start);
        }

        private void LoadCalendarForDate(DateTime localDate)
        {
            //start/end of that day in local time
            DateTime dayStartLocal = localDate.Date;
            DateTime dayEndLocal = dayStartLocal.AddDays(1);

            //convert to UTC for DB
            DateTime dayStartUtc = TimeZoneInfo.ConvertTimeToUtc(dayStartLocal, TimeZoneInfo.Local);
            DateTime dayEndUtc = TimeZoneInfo.ConvertTimeToUtc(dayEndLocal, TimeZoneInfo.Local);

            var repo = new AppointmentRepository();
            var appts = repo.GetInRange(dayStartUtc, dayEndUtc);

            //convert to nice format for data grid
            var view = appts.Select(a => new
            {
                a.AppointmentID,
                a.CustomerName,
                a.UserName,
                a.Title,
                a.Type,
                Start = TimeZoneInfo.ConvertTimeFromUtc(a.StartUtc, TimeZoneInfo.Local),
                End = TimeZoneInfo.ConvertTimeFromUtc(a.EndUtc, TimeZoneInfo.Local)
            }).ToList();

            dataGridViewCalendarAppointments.DataSource = view;
        }
    }
}
