using Bootcamp601.Entities;
using Bootcamp601.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bootcamp601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerOperations customerOperations = new CustomerOperations();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                CustomerFirstName = txtCustomerFirstName.Text,
                CustomerLastName = txtCustomerLastName.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerTotal = int.Parse(txtCustomerTotal.Text)
            };

            customerOperations.AddCustomer(customer);
            MessageBox.Show("Müşteri ekleme başarılı", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomersList();
            dataGridView1.DataSource = customers;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            customerOperations.DeleteCustomer(id);
            MessageBox.Show("Müşteri sorunsuz silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var updatedCustomer = new Customer
            {
                CustomerId = id,
                CustomerFirstName = txtCustomerFirstName.Text,
                CustomerLastName = txtCustomerLastName.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerTotal = int.Parse(txtCustomerTotal.Text)
            };
            customerOperations.UpdateCustomer(updatedCustomer);
            MessageBox.Show("Müşteri bilgileri güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var customer = customerOperations.GetCustomerById(id);
            dataGridView1.DataSource = new List<Customer> { customer };

        }
    }
}
 