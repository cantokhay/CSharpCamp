using Bootcamp.FinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bootcamp.FinancialCRM
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        BootcampFinancialCRMEntities db = new BootcampFinancialCRMEntities();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var user = db.Users.FirstOrDefault(u => u.UserName == txtUsername.Text && u.Password == txtPassword.Text);
                if (user != null)
                {
                    SessionManager.LoggedInUserId = user.UserId;
                    MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmDashboard frmDashboard = new FrmDashboard();
                    frmDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
