using Bootcamp.BusinessLayer.Abstract;
using Bootcamp.BusinessLayer.Concrete;
using Bootcamp.DataAccessLayer.EntityFramework;
using Bootcamp.EntityLayer.Concrete;
using System;
using System.Windows.Forms;

namespace Bootcamp.Presentation
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EFCategoryDal());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categories = _categoryService.TGetAll();
            dgvCategoriesList.DataSource = categories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                CategoryName = txtCategoryName.Text,
                CategoryStatus = true
            };
            _categoryService.TInsert(category);
            MessageBox.Show("Category added successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(txtCategoryId.Text);
            var value = _categoryService.TGetById(categoryId);
            _categoryService.TDelete(value);
            MessageBox.Show("Category deleted finally!");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(txtCategoryId.Text);
            var value = _categoryService.TGetById(categoryId);
            dgvCategoriesList.DataSource = value;
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(txtCategoryId.Text);
            var value = _categoryService.TGetById(categoryId);
            value.CategoryName = txtCategoryName.Text;
            value.CategoryStatus = true;
            _categoryService.TUpdate(value);
            MessageBox.Show("Category updated successfully!");
        }
    }
}
