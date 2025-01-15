using Bootcamp.FinancialCRM.Models;
using System;
using System.Windows.Forms;

namespace Bootcamp.FinancialCRM
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        BootcampFinancialCRMEntities db = new BootcampFinancialCRMEntities();

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Şifrenizi değiştirmek istediğinize emin misiniz?", "Şifre Değiştirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtNewPassword.Text == txtNewPasswordAgain.Text)
                {
                    int userId = SessionManager.LoggedInUserId;
                    var user = db.Users.Find(userId);

                    if (user != null)
                    {
                        user.Password = txtNewPassword.Text;
                        db.SaveChanges();
                        MessageBox.Show("Şifre değiştirme işlemi başarılı bir şekilde gerçekleşti!", "Şifre Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Owner.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
