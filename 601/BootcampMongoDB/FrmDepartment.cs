using Bootcamp601.ConnStr;
using System;
using System.Windows.Forms;

namespace Bootcamp601
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        string connectionString = PostgreConnectionString.ConnStr();

        private void btnGoToEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmployee = new FrmEmployee();
            frmEmployee.Show();
            this.Hide();
        }
    }
}
