using Bootcamp.BusinessLayer.Concrete;
using Bootcamp.DataAccessLayer.EntityFramework;
using System;
using System.Windows.Forms;

namespace Bootcamp.Presentation
{
    public partial class FrmProduct : Form
    {
        private readonly ProductManager _productManager;
        public FrmProduct()
        {
            InitializeComponent();
            _productManager = new ProductManager(new EFProductDal());
        }

        //ProductManager productManager = new ProductManager(new EFProductDal());

        private void btnList_Click(object sender, EventArgs e)
        {
            var products = _productManager.TGetAll();
            dgvProductsList.DataSource = products;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var products = _productManager.TGetProductsWithCategory();
            dgvProductsList.DataSource = products;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
