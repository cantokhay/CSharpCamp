using Bootcamp.FinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bootcamp.FinancialCRM
{
    public partial class FrmInvoices : Form
    {
        public FrmInvoices()
        {
            InitializeComponent();
        }

        BootcampFinancialCRMEntities db = new BootcampFinancialCRMEntities();

        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            //LoadInvoiceList();
            ClearTextBoxes();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadInvoiceList(); 
            ClearTextBoxes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Invoices invoice = new Invoices();

            PopulateInvoiceDetails(invoice);

            db.Invoices.Add(invoice);
            db.SaveChanges();
            MessageBox.Show("Fatura ödemesi başarılı bir şekilde gerçekleşti!", "Fatura Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadInvoiceList();
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Fatura Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if (result == DialogResult.OK)
            {
                int id = int.Parse(txtInvoiceId.Text);
                var invoice = db.Invoices.Find(id);
                db.Invoices.Remove(invoice);
                db.SaveChanges();
                MessageBox.Show("Fatura silme işlemi başarılı bir şekilde gerçekleşti!", "Fatura Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fatura silme işlemi iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadInvoiceList();
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Fatura Güncelle", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                int id = int.Parse(txtInvoiceId.Text);
                var invoice = db.Invoices.Find(id);
                PopulateInvoiceDetails(invoice);
                db.SaveChanges();
                MessageBox.Show("Fatura güncelleme işlemi başarılı bir şekilde gerçekleşti!", "Fatura Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fatura güncelleme işlemi iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadInvoiceList();
            ClearTextBoxes();
        }

        #region Left Panel Buttons

        private void btnBanks_Click(object sender, EventArgs e)
        {
            Form frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Extracted Methods

        private void LoadInvoiceList()
        {
            var values = db.Invoices.ToList();
            dgvInvoiceList.DataSource = values;
        }

        private void PopulateInvoiceDetails(Invoices invoice)
        {
            invoice.InvoiceTitle = txtInvoiceTitle.Text;
            invoice.InvoiceAmount = decimal.Parse(txtInvoiceAmount.Text);
            invoice.InvoicePeriod = txtInvoicePeriod.Text;
        }

        private void ClearTextBoxes()
        {
            txtInvoiceId.Clear();
            txtInvoiceTitle.Clear();
            txtInvoiceAmount.Clear();
            txtInvoicePeriod.Clear();
        }

        #endregion

    }
}
