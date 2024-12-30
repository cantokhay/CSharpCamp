using Bootcamp.BusinessLayer.Concrete;
using Bootcamp.DataAccessLayer.EntityFramework;
using Bootcamp.EntityLayer.Concrete;
using System;
using System.Windows.Forms;

namespace Bootcamp.Presentation
{
    public partial class FrmProduct : Form
    {
        private readonly ProductManager _productService;
        private readonly CategoryManager _categoryService;

        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDal());
            _categoryService = new CategoryManager(new EFCategoryDal());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var products = _productService.TGetAll();
            dgvProductsList.DataSource = products;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var products = _productService.TGetProductsWithCategory();
            dgvProductsList.DataSource = products;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(productId);
            _productService.TDelete(value);
            MessageBox.Show("Product deleted finally!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cmbCategories.SelectedValue.ToString());
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductName = txtProductName.Text;
            product.ProductDescription = txtProductDescription.Text;
            product.ProductStock = int.Parse(numProductStock.Text);
            _productService.TInsert(product);
            MessageBox.Show("Product added successfully.");
        }

        private void btnFrmCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
            this.Hide();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(productId);
            dgvProductsList.DataSource = value;
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(productId);
            value.CategoryId = int.Parse(cmbCategories.SelectedValue.ToString());
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductName = txtProductName.Text;
            value.ProductDescription = txtProductDescription.Text;
            value.ProductStock = int.Parse(numProductStock.Text);
            _productService.TUpdate(value);
            MessageBox.Show("Product updated successfully!");
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbCategories.DataSource = values;
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryId";
        }
    }
}
