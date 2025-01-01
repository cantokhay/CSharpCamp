using Bootcamp601.ConnStr;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bootcamp601
{
    public partial class FrmPostgreSQL : Form
    {
        public FrmPostgreSQL()
        {
            InitializeComponent();
        }

        string connectionString = PostgreConnectionString.ConnStr();

        void GetAllCustomers()
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM Customers";
            var command = new NpgsqlCommand(query, conn);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerFirstName = txtCustomerFirstName.Text;
            string customerLastName = txtCustomerLastName.Text;
            string customerCity = txtCustomerCity.Text;

            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string query = "INSERT INTO Customers (CustomerFirstName, CustomerLastName, CustomerCity) VALUES (@customerFirstName, @customerLastName, @customerCity)";
            var command = new NpgsqlCommand(query, conn);
            command.Parameters.AddWithValue("@customerFirstName", customerFirstName);
            command.Parameters.AddWithValue("@customerLastName", customerLastName);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show("Müşteri başarıyla eklendi!");
            conn.Close();
            GetAllCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string query = "DELETE FROM Customers WHERE CustomerId = @customerId";
            var command = new NpgsqlCommand(query, conn);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Müşteri sorunsuz silindi!");
            conn.Close();
            GetAllCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerId.Text);
            string customerFirstName = txtCustomerFirstName.Text;
            string customerLastName = txtCustomerLastName.Text;
            string customerCity = txtCustomerCity.Text;

            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE Customers SET CustomerFirstName = @customerFirstName, CustomerLastName = @customerLastName, CustomerCity = @customerCity WHERE CustomerId = @customerId";
            var command = new NpgsqlCommand(query, conn);
            command.Parameters.AddWithValue("@customerId", customerId);
            command.Parameters.AddWithValue("@customerFirstName", customerFirstName);
            command.Parameters.AddWithValue("@customerLastName", customerLastName);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show("Müşteri başarıyla güncellendi!");
            conn.Close();
            GetAllCustomers();
        }
    }
}