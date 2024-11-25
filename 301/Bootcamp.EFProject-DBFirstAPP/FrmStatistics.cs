using System;
using System.Linq;
using System.Windows.Forms;

namespace Bootcamp.EFProject_DBFirstAPP
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        BootcampEFDBFirstEntities db = new BootcampEFDBFirstEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblTotalLocationStat.Text = db.Location.Count().ToString();
            lblTotalCapacityStat.Text = db.Location.Sum(x => x.LocationCapacity).ToString();
            lblTotalGuideStat.Text = db.Guide.Count().ToString();
            lblAverageCapacityStat.Text = db.Location.Average(x => x.LocationCapacity)?.ToString("F0") ?? "0.00";
            lblAverageLocationPriceStat.Text = (db.Location.Average(x => x.LocationPrice)?.ToString("F2") ?? "0.00") + " ₺";
            lblLastAddedLocationStat.Text = db.Location.OrderByDescending(x => x.LocationId).FirstOrDefault().LocationCountry;
            lblCapacityOfWienStat.Text = db.Location.Where(x => x.LocationCity == "Wien").Select(x => x.LocationCapacity).FirstOrDefault().ToString();
            lblAverageCapacityOfTurkiyeStat.Text = db.Location.Where(x => x.LocationCountry == "Türkiye").Average(x => x.LocationCapacity)?.ToString("F0") ?? "0.00";
            lblGuideNameOfRomeStat.Text = (db.Location.Where(x => x.LocationCity == "Rome").FirstOrDefault().Guide.GuideFirstName) + " " + (db.Location.Where(x => x.LocationCity == "Rome").FirstOrDefault().Guide.GuideLastName);
            lblMaxCapacityLocationStat.Text = db.Location.OrderByDescending(x => x.LocationCapacity).FirstOrDefault().LocationCity;
            lblMaxPricedLocationStat.Text = db.Location.OrderByDescending(x => x.LocationPrice).FirstOrDefault().LocationCity;
            lblCanTokhayLocationCountStat.Text = db.Location.Where(x => x.Guide.GuideFirstName == "Can" && x.Guide.GuideLastName == "Tokhay").Count().ToString(); 
        }
    }
}
