using Bootcamp.FinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bootcamp.FinancialCRM
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        BootcampFinancialCRMEntities db = new BootcampFinancialCRMEntities();

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            //LoadCategoryList();
            ClearTextBoxes();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadCategoryList();
            ClearTextBoxes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateCategoryInfo()) return;

            Categories Category = new Categories();

            PopulateCategoryDetails(Category);

            db.Categories.Add(Category);
            db.SaveChanges();
            MessageBox.Show("Kategori ekleme işlemi başarılı bir şekilde gerçekleşti!", "Kategori Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadCategoryList();
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Kategori Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if (!ValidateCategoryId()) return;


            if (result == DialogResult.OK)
            {
                int id = int.Parse(txtCategoryId.Text);
                var Category = db.Categories.Find(id);
                db.Categories.Remove(Category);
                db.SaveChanges();
                MessageBox.Show("Kategori silme işlemi başarılı bir şekilde gerçekleşti!", "Kategori Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Kategori silme işlemi iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadCategoryList();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Kategori Güncelle", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (!ValidateCategoryId() || !ValidateCategoryInfo()) return;

            if (result == DialogResult.OK)
            {
                int id = int.Parse(txtCategoryId.Text);
                var Category = db.Categories.Find(id);
                PopulateCategoryDetails(Category);
                db.SaveChanges();
                MessageBox.Show("Kategori güncelleme işlemi başarılı bir şekilde gerçekleşti!", "Kategori Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori güncelleme işlemi iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadCategoryList();
            ClearTextBoxes();
        }

        #region Left Panel Buttons

        private void btnBanks_Click(object sender, EventArgs e)
        {
            Form frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            Form frmInvoices = new FrmInvoices();
            frmInvoices.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            Form frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
            Form frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form frmSettings = new FrmSettings();
            frmSettings.Owner = this;
            frmSettings.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Extracted Methods

        private void LoadCategoryList()
        {
            var values = db.Categories.ToList();
            dgvCategoriesList.DataSource = values;
        }

        private void PopulateCategoryDetails(Categories categories)
        {
            categories.CategoryName = txtCategoryName.Text;
        }

        private void ClearTextBoxes()
        {
            txtCategoryId.Clear();
            txtCategoryName.Clear();
        }

        #endregion

        #region Validation Methods

        private bool ValidateCategoryInfo()
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateCategoryId()
        {
            if (string.IsNullOrEmpty(txtCategoryId.Text))
            {
                MessageBox.Show("Kategori ID boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txtCategoryId.Text, out _))
            {
                MessageBox.Show("Kategori ID sayısal bir değer olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

    }
}
