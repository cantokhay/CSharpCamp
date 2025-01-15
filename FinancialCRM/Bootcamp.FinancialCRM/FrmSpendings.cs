using Bootcamp.FinancialCRM.DTOs.SpendingDTOs;
using Bootcamp.FinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bootcamp.FinancialCRM
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            LoadCategoryCombobox();
            ClearTextBoxes();
        }

        BootcampFinancialCRMEntities db = new BootcampFinancialCRMEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadSpendingList();
            ClearTextBoxes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateSpendingInfo()) return;

            Spendings spending = new Spendings();

            PopulateSpendingDetails(spending);

            db.Spendings.Add(spending);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde gerçekleşti!", "Harcama Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadSpendingList();
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Harcama Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if (!ValidateSpendingId()) return;

            if (result == DialogResult.OK)
            {
                int id = int.Parse(txtSpendingId.Text);
                var spending = db.Spendings.Find(id);
                db.Spendings.Remove(spending);
                db.SaveChanges();
                MessageBox.Show("Harcama silme işlemi başarılı bir şekilde gerçekleşti!", "Harcama Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Harcama silme işlemi iptal edildi!", "Harcama Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadSpendingList();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Harcama Güncelleme", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if (!ValidateSpendingId() || !ValidateSpendingInfo()) return;

            if (result == DialogResult.OK)
            {
                int id = int.Parse(txtSpendingId.Text);
                var spending = db.Spendings.Find(id);
                PopulateSpendingDetails(spending);
                db.SaveChanges();
                MessageBox.Show("Harcama güncelleme işlemi başarılı bir şekilde gerçekleşti!", "Harcama Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Harcama güncelleme işlemi iptal edildi!", "Harcama Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadSpendingList();
            ClearTextBoxes();
        }

        #region Left Panel Buttons

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Form frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

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

        private void LoadSpendingList()
        {
            var values = db.Spendings.Select(x => new ResultSpendingDTO
            {
                SpendingId = x.SpendingId,
                SpendingTitle = x.SpendingTitle,
                SpendingAmount = (decimal)(x.SpendingAmount),
                SpendingDate = (DateTime)x.SpendingDate,
                CategoryId = (int)x.CategoryId,
                CategoryName = x.Categories.CategoryName
            }).ToList();
            dgvSpendingsList.DataSource = values;
        }

        private void LoadCategoryCombobox()
        {
            var values = db.Categories.ToList();
            values.Insert(0, new Categories
            {
                CategoryId = -1,
                CategoryName = "Lütfen bir kategori seçiniz"
            });
            cbxSpendingCategory.DataSource = values;
            cbxSpendingCategory.DisplayMember = "CategoryName";
            cbxSpendingCategory.ValueMember = "CategoryId";

            cbxSpendingCategory.SelectedIndex = 0;
        }

        private void PopulateSpendingDetails(Spendings spending)
        {
            spending.SpendingTitle = txtSpendingTitle.Text;
            spending.SpendingAmount = decimal.Parse(txtSpendingAmount.Text);
            spending.SpendingDate = dtpSpendingDate.Value;
            spending.Categories = (Categories)cbxSpendingCategory.SelectedItem;
        }

        private void ClearTextBoxes()
        {
            txtSpendingId.Clear();
            txtSpendingTitle.Clear();
            txtSpendingAmount.Clear();
            dtpSpendingDate.Value = DateTime.Now;
            cbxSpendingCategory.SelectedIndex = 0;
        }

        #endregion

        #region Validation Methods

        private bool ValidateSpendingInfo()
        {
            if (string.IsNullOrEmpty(txtSpendingTitle.Text))
            {
                MessageBox.Show("Harcama başlığı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtSpendingAmount.Text))
            {
                MessageBox.Show("Harcama tutarı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!decimal.TryParse(txtSpendingAmount.Text, out _))
            {
                MessageBox.Show("Harcama tutarı finansal bir değer olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxSpendingCategory.SelectedIndex == 0 || ((Categories)cbxSpendingCategory.SelectedItem).CategoryId == -1)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateSpendingId()
        {
            if (string.IsNullOrEmpty(txtSpendingId.Text))
            {
                MessageBox.Show("Harcama ID boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txtSpendingId.Text, out _))
            {
                MessageBox.Show("Harcama ID sayısal bir değer olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

    }
}
