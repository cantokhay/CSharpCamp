using Bootcamp.FinancialCRM.DTOs.BankProcessDTOs;
using Bootcamp.FinancialCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bootcamp.FinancialCRM
{
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }

        BootcampFinancialCRMEntities db = new BootcampFinancialCRMEntities();

        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            LoadBankAndProcessTypeComboboxes();
            ClearTextBoxes();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadBankProcessesList();
            ClearTextBoxes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateBankProcessInfo()) return;

            BankProcesses process = new BankProcesses();

            PopulateSpendingDetails(process);

            db.BankProcesses.Add(process);
            db.SaveChanges();
            MessageBox.Show("Banka hareketi başarılı bir şekilde gerçekleşti!", "Banka İşlemi Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadBankProcessesList();
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Banka İşlemi Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if (!ValidateBankProcessId()) return;

            if (result == DialogResult.OK)
            {
                int id = int.Parse(txtBankProcessId.Text);
                var process = db.BankProcesses.Find(id);
                db.BankProcesses.Remove(process);
                db.SaveChanges();
                MessageBox.Show("Banka işlemi silme işlemi başarılı bir şekilde gerçekleşti!", "Banka İşlemi Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Banka işlemi silme işlemi iptal edildi!", "Banka İşlemi Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadBankProcessesList();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Banka İşlemi Güncelleme", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if (!ValidateBankProcessId() || !ValidateBankProcessInfo()) return;

            if (result == DialogResult.OK)
            {
                int id = int.Parse(txtBankProcessId.Text);
                var process = db.BankProcesses.Find(id);
                PopulateSpendingDetails(process);
                db.SaveChanges();
                MessageBox.Show("Banka işlemi güncelleme işlemi başarılı bir şekilde gerçekleşti!", "Banka İşlemi Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Banka işlemi güncelleme işlemi iptal edildi!", "Banka İşlemi Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadBankProcessesList();
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

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            Form frmSpendings = new FrmSpendings();
            frmSpendings.Show();
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

        private void LoadBankProcessesList()
        {
            var values = db.BankProcesses.Select(x => new ResultBankProcessDTO
            {
                BankProcessId = x.BankProcessId,
                Description = x.Description,
                Amount = (decimal)x.Amount,
                ProcessDate = (DateTime)x.ProcessDate,
                ProcessType = x.ProcessType,
                BankId = (int)x.BankId,
                BankName = x.Banks.BankTitle
            }).ToList();
            dgvBankProcessesList.DataSource = values;
        }

        private void LoadBankAndProcessTypeComboboxes()
        {
            var bankValues = db.Banks.ToList();
            bankValues.Insert(0, new Banks
            {
                BankId = -1,
                BankTitle = "Lütfen bir banka seçiniz"
            });
            cbxBankProcessBank.DataSource = bankValues;
            cbxBankProcessBank.DisplayMember = "BankTitle";
            cbxBankProcessBank.ValueMember = "BankId";
            cbxBankProcessBank.SelectedIndex = 0;

            var processTypeValues = new List<string>() { "Lütfen bir hareket türü seçiniz", "Gelen Havale", "Giden Havale" };
            cbxBankProcessType.DataSource = processTypeValues;
            cbxBankProcessType.SelectedIndex = 0;
        }

        private void PopulateSpendingDetails(BankProcesses process)
        {
            process.Description = txtBankProcessDecription.Text;
            process.Amount = decimal.Parse(txtBankProcessAmount.Text);
            process.ProcessDate = dtpBankProcessDate.Value;
            process.ProcessType = cbxBankProcessType.SelectedItem.ToString();
            process.BankId = ((Banks)cbxBankProcessBank.SelectedItem).BankId;
        }

        private void ClearTextBoxes()
        {
            txtBankProcessId.Clear();
            txtBankProcessDecription.Clear();
            txtBankProcessAmount.Clear();
            dtpBankProcessDate.Value = DateTime.Now;
            cbxBankProcessBank.SelectedIndex = 0;
            cbxBankProcessType.SelectedIndex = 0;
        }

        #endregion

        #region Validation Methods

        private bool ValidateBankProcessInfo()
        {
            if (string.IsNullOrEmpty(txtBankProcessDecription.Text))
            {
                MessageBox.Show("Harcama açıklaması boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtBankProcessAmount.Text))
            {
                MessageBox.Show("Harcama tutarı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!decimal.TryParse(txtBankProcessAmount.Text, out _))
            {
                MessageBox.Show("Harcama tutarı finansal bir değer olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxBankProcessBank.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen bir banka seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxBankProcessType.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen bir hareket türü seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateBankProcessId()
        {
            if (string.IsNullOrEmpty(txtBankProcessId.Text))
            {
                MessageBox.Show("Harcama ID boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txtBankProcessId.Text, out _))
            {
                MessageBox.Show("Harcama ID sayısal bir değer olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion
    }
}
