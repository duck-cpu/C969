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
            if (dataGridCustomers == null)
                return;

            var customer = (Customer)dataGridCustomers.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Delete customer?", "CONFIRM",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                //new CustomerRepository().Delete(customer.CustomerID);
                LoadCustomers();
                }
        }
    }
}
