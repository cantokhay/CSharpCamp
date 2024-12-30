using BootcampDapper.ConnStr;
using BootcampDapper.DTOs;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootcampDapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = DatabaseConnectionString.ConnStr();

        private async void Form1_Load(object sender, EventArgs e)
        {
            await GetStats();
            await ProductList();
        }

        private async void btnList_Click(object sender, EventArgs e)
        {
            await ProductList();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Products (ProductName, ProductPrice, ProductStock, ProductCategory) values (@productName, @productPrice, @productStock, @ProductCategory)";
            DynamicParameters parameters = AddingDynamicParameters();
            await conn.ExecuteAsync(query, parameters);
            MessageBox.Show("Yeni ürün başarıyla eklendi");
            await ProductList();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Products WHERE ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", txtProductId.Text);
            await conn.ExecuteAsync(query, parameters);
            MessageBox.Show("Ürün sorunsuz silindi");
            await ProductList();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Products SET ProductName = @productName, ProductPrice = @productPrice, ProductStock = @productStock, ProductCategory = @ProductCategory WHERE ProductId = @productId";
            DynamicParameters parameters = AddingDynamicParameters();
            parameters.Add("@productId", txtProductId.Text);
            conn.Execute(query, parameters);
            MessageBox.Show("Ürün başarıyla güncellendi");
            await ProductList();
        }

        DynamicParameters AddingDynamicParameters()
        {
            var parametersFromBaseMethod = new DynamicParameters();
            parametersFromBaseMethod.Add("@productName", txtProductName.Text);
            parametersFromBaseMethod.Add("@productPrice", txtProductPrice.Text);
            parametersFromBaseMethod.Add("@productStock", txtProductStock.Text);
            parametersFromBaseMethod.Add("@ProductCategory", txtProductCategory.Text);
            return parametersFromBaseMethod;
        }

        private async Task ProductList()
        {
            string query = "SELECT * FROM Products";
            var values = await conn.QueryAsync<ResultProductDTO>(query);
            dataGridView1.DataSource = values.ToList();
        }

        private async Task GetStats()
        {
            string queryOfCount = "SELECT COUNT(*) FROM Products";
            var totalProduct = await conn.QueryFirstOrDefaultAsync<int>(queryOfCount);
            lblTotalProductCountStat.Text = totalProduct.ToString();

            string queryOfMaxPrice = "SELECT ProductName From Products Where ProductPrice = (SELECT MAX(ProductPrice) FROM Products)";
            var maxPrice = await conn.QueryFirstOrDefaultAsync<string>(queryOfMaxPrice);
            lblMaxPricedProductStat.Text = maxPrice.ToString();

            string queryOfCategoryCount = "SELECT COUNT(DISTINCT(ProductCategory)) FROM Products";
            var categoryCount = await conn.QueryFirstOrDefaultAsync<int>(queryOfCategoryCount);
            lblCategoryCountStat.Text = categoryCount.ToString();
        }
    }
}