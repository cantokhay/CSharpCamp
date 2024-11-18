using System;
using System.Linq;
using System.Windows.Forms;

namespace Bootcamp.EFProject_DBFirstAPP
{
    public partial class Form1 : Form
    {
        BootcampEFDBFirstEntities db = new BootcampEFDBFirstEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide
            {
                GuideFirstName = txtFirstName.Text,
                GuideLastName = txtLastName.Text
            };
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var result = db.Guide.Find(id);
            db.Guide.Remove(result);
            db.SaveChanges();
            MessageBox.Show("Rehber Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var result = db.Guide.Find(id);
            result.GuideFirstName = txtFirstName.Text;
            result.GuideLastName = txtLastName.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var result = db.Guide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = result;
        }
    }
}
