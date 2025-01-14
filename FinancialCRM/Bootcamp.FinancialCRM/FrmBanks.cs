using System;
using System.Linq;
using System.Windows.Forms;
using Bootcamp.FinancialCRM.Models;

namespace Bootcamp.FinancialCRM
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        BootcampFinancialCRMEntities db = new BootcampFinancialCRMEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat").Select(y => y.BankBalance).FirstOrDefault();
            var garantiBankBalance = db.Banks.Where(x => x.BankTitle == "Garanti").Select(y => y.BankBalance).FirstOrDefault();
            var yapiKrediBankBalance = db.Banks.Where(x => x.BankTitle == "Yapı Kredi").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankStat.Text = ziraatBankBalance.ToString() + " ₺";
            lblGarantiBankStat.Text = garantiBankBalance.ToString() + " ₺";
            lblYapiKrediBankStat.Text = yapiKrediBankBalance.ToString() + " ₺";

            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(1).FirstOrDefault();
            lblBankProcess1.Text = $"{bankProcess1.Description}   {bankProcess1.Amount} ₺    {bankProcess1.ProcessDate?.ToString("dd-MM-yyyy")}";

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = $"{bankProcess2.Description}   {bankProcess2.Amount} ₺    {bankProcess2.ProcessDate?.ToString("dd-MM-yyyy")}";

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = $"{bankProcess3.Description}   {bankProcess3.Amount} ₺    {bankProcess3.ProcessDate?.ToString("dd-MM-yyyy")}";

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = $"{bankProcess4.Description}   {bankProcess4.Amount} ₺    {bankProcess4.ProcessDate?.ToString("dd-MM-yyyy")}";

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = $"{bankProcess5.Description}   {bankProcess5.Amount} ₺    {bankProcess5.ProcessDate?.ToString("dd-MM-yyyy")}";
        }

        #region Left Panel Buttons

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            Form frmInvoices = new FrmInvoices();
            frmInvoices.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        #endregion
    }
}
