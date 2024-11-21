using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootcamp.EFProject_DBFirstAPP
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        BootcampEFDBFirstEntities db = new BootcampEFDBFirstEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dgvLocationsList.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                x.GuideId,
                GuideFullName = x.GuideFirstName + " " + x.GuideLastName
            }).ToList();
            cbxGuide.DisplayMember = "GuideFullName";
            cbxGuide.ValueMember = "GuideId";
            cbxGuide.DataSource = values;
            cbxGuide.SelectedIndex = -1;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCity = txtCity.Text;
            location.LocationPrice = decimal.Parse(txtPrice.Text);
            location.LocationCapacity = (byte)numCapacity.Value; //casting. Means that I promise it will come as byte.
            location.LocationCountry = txtCountry.Text;
            location.LocationDayNight = txtDayNight.Text;
            location.GuideId = Convert.ToInt32(cbxGuide.SelectedValue); //converting. Another practice of value conversion.
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Location added successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var location = db.Location.Find(id);
            db.Location.Remove(location);
            db.SaveChanges();
            MessageBox.Show("Location deleted successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var location = db.Location.Find(id);
            location.LocationCity = txtCity.Text;
            location.LocationPrice = decimal.Parse(txtPrice.Text);
            location.LocationCapacity = (byte)numCapacity.Value;
            location.LocationCountry = txtCountry.Text;
            location.LocationDayNight = txtDayNight.Text;
            location.GuideId = Convert.ToInt32(cbxGuide.SelectedValue);
            db.SaveChanges();
            MessageBox.Show("Location updated successfully!");
        }
    }
}
