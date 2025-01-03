using Bootcamp601.ConnStr;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bootcamp601
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        string connectionString = PostgreConnectionString.ConnStr();

        void EmployeeList()
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM Employees";
            var command = new NpgsqlCommand(query, conn);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        void DeparmentList()
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM Departments";
            var command = new NpgsqlCommand(query, conn);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbxEmployeeDepartment.DisplayMember = "DepartmentName";
            cbxEmployeeDepartment.ValueMember = "DepartmentId";
            cbxEmployeeDepartment.DataSource = dataTable;
            conn.Close();
        }

        private void btnGoToDepartment_Click(object sender, EventArgs e)
        {
            FrmDepartment frmDepartment = new FrmDepartment();
            frmDepartment.Show();
            this.Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeList();
            DeparmentList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string employeeFirstName = txtEmployeeFirstName.Text;
            string employeeLastName = txtEmployeeLastName.Text;
            decimal employeeSalary = decimal.Parse(txtEmployeeSalary.Text);
            int employeeDepartmentId = int.Parse(cbxEmployeeDepartment.SelectedValue.ToString());

            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string query = "INSERT INTO Employees (EmployeeFirstName, EmployeeLastName, EmployeeSalary, DepartmentId) VALUES (@employeeFirstName, @employeeLastName, @employeeSalary, @employeeDepartmentId)";
            var command = new NpgsqlCommand(query, conn);
            command.Parameters.AddWithValue("@employeeFirstName", employeeFirstName);
            command.Parameters.AddWithValue("@employeeLastName", employeeLastName);
            command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
            command.Parameters.AddWithValue("@employeeDepartmentId", employeeDepartmentId);
            command.ExecuteNonQuery();
            MessageBox.Show("Çalışan başarıyla eklendi!");
            conn.Close();
            EmployeeList();
        }
    }
}
