using BootcampMongoDB.Services;
using System;
using System.Windows.Forms;

namespace BootcampMongoDB
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
            var customer = new Entities.Customer
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
    }
}
