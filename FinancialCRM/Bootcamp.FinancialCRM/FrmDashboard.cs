using Bootcamp.FinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bootcamp.FinancialCRM
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        BootcampFinancialCRMEntities db = new BootcampFinancialCRMEntities();
        int count = 0;

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastBankProcessAmount = db.BankProcesses.Where(x => x.ProcessType == "Gelen Havale").OrderByDescending(x => x.ProcessDate).Select(x => x.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

            #region Chart Bank Data
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();

            chartBankData.Series.Clear();
            var series1 = chartBankData.Series.Add("₺");
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            foreach (var item in bankData)
            {
                series1.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            #endregion

            #region Chart Invoice Data

            var invoiceData = db.Invoices.Select(x => new
            {
                x.InvoiceTitle,
                x.InvoiceAmount
            }).ToList();

            chartInvoiceData.Series.Clear();
            var series2 = chartInvoiceData.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            foreach (var item in invoiceData)
            {
                series2.Points.AddXY(item.InvoiceTitle, item.InvoiceAmount);
            }

            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                var invoiceAmountmod1 = db.Invoices.Where(x => x.InvoiceTitle == "Elektrik Faturası").Select(x => x.InvoiceAmount).FirstOrDefault();
                lblInvoiceTitle.Text = "Elektrik Faturası";
                lblInvoiceAmount.Text = invoiceAmountmod1.ToString() + " ₺";
            }
            if (count % 4 == 2)
            {
                var invoiceAmountmod2 = db.Invoices.Where(x => x.InvoiceTitle == "Su Faturası").Select(x => x.InvoiceAmount).FirstOrDefault();
                lblInvoiceTitle.Text = "Su Faturası";
                lblInvoiceAmount.Text = invoiceAmountmod2.ToString() + " ₺";
            }
            if (count % 4 == 3)
            {
                var invoiceAmountmod3 = db.Invoices.Where(x => x.InvoiceTitle == "Doğalgaz Faturası").Select(x => x.InvoiceAmount).FirstOrDefault();
                lblInvoiceTitle.Text = "Doğalgaz Faturası";
                lblInvoiceAmount.Text = invoiceAmountmod3.ToString() + " ₺";
            }
            if (count % 4 == 0)
            {
                var invoiceAmountmod4 = db.Invoices.Where(x => x.InvoiceTitle == "İnternet Faturası").Select(x => x.InvoiceAmount).FirstOrDefault();
                lblInvoiceTitle.Text = "İnternet Faturası";
                lblInvoiceAmount.Text = invoiceAmountmod4.ToString() + " ₺";
            }
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

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
            Form frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
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

        //C# Eğitim Kampı Final Case
        //Bu kısma kadar başarıyla geldiğiniz için tebrik ederim!

        //Case: Finalde sizden istenen tek bir case var.Şöyle ki; FinancialCrm projesinde oluşturduğumuz alanlarda derste yapmadıklarımızı sizin tamamlamanızı bekliyoruz.Ek olarak mutlaka projede bir login formu olmalı ve login işlemi Entity Framework ile yapılmalıdır.

        //Github: Projenin final kısmını Github'da daha önceki caselerde olduğu gibi yine maddeli yapılar ve ekran alıntıları ile paylaşmanızı rica ediyoruz.

        //Staj: Staj için ayrıca bir duyuruyu Linkedin'den paylaşacağım. Bu staj seçimi sadece kampı uygulayanlar arasında olacak.

        //Linkedin Paylaşımı: Sertifikanız size iletildikten sonra Linkedin'de emojilerle süslenmiş güzel bir metin paylaşmanızı ve beni etiketlemenizi rica edeceğim ağınıza epey katkı sağlarım. Buradaki metin için örneği 30 ders boyunca öğrendiğiniz konu başlıkları vs. olabilir bunu chatgpt ile güzel bir hale getirebilirsiniz :)
        //https://docs.google.com/forms/d/e/1FAIpQLSfo1BqGlHAIxOtJBA9Dn2w9TzXvg06Wf15Oqt4Op1R2TH5hyg/viewform

    }
}
