using BootcampPostgreSQL.ConnStr;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace BootcampPostgreSQL
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
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }
    }
}
