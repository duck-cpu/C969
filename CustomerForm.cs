using C969.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using C969.Models;
using MySql.Data.MySqlClient;
using C969.Helpers;

namespace C969
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.SelectedItem is not Country selectedCountry)
                return;

            int countryID = selectedCountry.CountryID;

            var cities = new CityRepository().GetByCountry(countryID);
            comboBoxCity.DataSource = cities;
            comboBoxCity.DisplayMember = "CityName";
            comboBoxCity.ValueMember = "CityID";
        }

        private void buttonCustomerSave_Click(object sender, EventArgs e)
        {
            //validation
            if (string.IsNullOrWhiteSpace(textBoxCustomerName.Text))
            {
                MessageBox.Show("Customer name required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress1.Text))
            {
                MessageBox.Show("Address required.");
                return;
            }

            if (!Regex.IsMatch(textBoxPhone.Text.Trim(), @"^[0-9-]+$"))
            {
                MessageBox.Show("Phone must contain only digits or dashes.");
                return;
            }

            var address = new Address
            {
                Address1 = textBoxAddress1.Text.Trim(),
                Address2 = textBoxAddress2.Text.Trim(),
                CityID = (int)comboBoxCity.SelectedValue,
                PostalCode = textBoxPostal.Text.Trim(),
                Phone = textBoxPhone.Text.Trim()
            };
            //update

            if (_editingCustomer == null)
            {
                int addressID = new AddressRepository().Add(address);

                using var conn = DB.GetConnection();
                conn.Open();

                string sql =
                "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                "VALUES (@n, @a, 1, NOW(), 'app', NOW(), 'app')";

                using var cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@n", textBoxCustomerName.Text.Trim());
                cmd.Parameters.AddWithValue("@a", addressID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer added.");
            }
            else
            {
                //edit mode
                using var conn = DB.GetConnection();
                conn.Open();

                string sqlAddressUpdate =
                    "UPDATE address SET " +
                    "address = @a1, address2 = @a2, cityId = @cityId, " +
                    "postalCode = @pc, phone = @phone, " +
                    "lastUpdate = NOW(), lastUpdateBy = 'app' " +
                    "WHERE addressId = @addrId;";

                using (var cmdAddr = new MySqlCommand(sqlAddressUpdate, conn))
                {
                    cmdAddr.Parameters.AddWithValue("@a1", textBoxAddress1.Text.Trim());     // <- use your actual control names
                    cmdAddr.Parameters.AddWithValue("@a2", textBoxAddress2.Text.Trim());
                    cmdAddr.Parameters.AddWithValue("@cityId", (int)comboBoxCity.SelectedValue);
                    cmdAddr.Parameters.AddWithValue("@pc", textBoxPostal.Text.Trim());
                    cmdAddr.Parameters.AddWithValue("@phone", textBoxPhone.Text.Trim());
                    cmdAddr.Parameters.AddWithValue("@addrId", _editingCustomer.Address.AddressId);

                    cmdAddr.ExecuteNonQuery();
                }

                string sqlCustomerUpdate =
                    "UPDATE customer SET " +
                    "customerName = @n, " +
                    "lastUpdate = NOW(), lastUpdateBy = 'app' " +
                    "WHERE customerId = @id;";

                using (var cmdCust = new MySqlCommand(sqlCustomerUpdate, conn))
                {
                    cmdCust.Parameters.AddWithValue("@n", textBoxCustomerName.Text.Trim());
                    cmdCust.Parameters.AddWithValue("@id", _editingCustomer.CustomerID);

                    cmdCust.ExecuteNonQuery();
                }

                MessageBox.Show("Customer updated.");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            var countries = new CountryRepository().GetAll();
            comboBoxCountry.DataSource = countries;
            comboBoxCountry.DisplayMember = "CountryName";
            comboBoxCountry.ValueMember = "CountryID";
        }

        private Customer _editingCustomer;

        public CustomerForm(Customer customer) : this()
        {
            _editingCustomer = customer;

            textBoxCustomerName.Text = customer.CustomerName;
            textBoxAddress1.Text = customer.Address.Address1;
            textBoxAddress2.Text = customer.Address.Address2;
            textBoxPostal.Text = customer.Address.PostalCode;
            textBoxPhone.Text = customer.Address.Phone;

            var countries = new CountryRepository().GetAll();
            comboBoxCountry.DataSource = countries;
            comboBoxCountry.DisplayMember = "CountryName";
            comboBoxCountry.ValueMember = "CountryId";

            var cityRepo = new CityRepository(); 
            var city = cityRepo.GetById(customer.Address.CityID);

            if (city != null)
            {
                comboBoxCountry.SelectedValue = city.CountryID;

                var cities = cityRepo.GetByCountry(city.CountryID);

                comboBoxCity.DataSource = cities;
                comboBoxCity.DisplayMember = "CityName";
                comboBoxCity.ValueMember = "CityId";

                comboBoxCity.SelectedValue = city.CityID;
            }
        }
    }
}
