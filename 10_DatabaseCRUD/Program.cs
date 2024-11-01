using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C - Create
            // R - Read
            // U - Update
            // D - Delete

            Console.WriteLine("***** Bootcamp Menu - Order Panel *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            #region Create a Category
            //Console.Write("Category Name that you want to add : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=CAN-TOKHAY-MASA\\CANTOKHAY; Initial Catalog=BootcampDb; User ID=sa; Password=230491Can.;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); // method is used to execute SQL commands that saves data to the database without any query filter. Means Save changes to the database.
            //connection.Close();

            //Console.WriteLine("Category Added Successfully!");
            #endregion

            #region Create a Product

            //string productName; 
            //decimal productPrice; 
            ////bool productStatus;

            //Console.Write("Product Name that you want to add : ");
            //productName = Console.ReadLine();

            //Console.Write("Product Price that you want to add : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            ////Console.Write("Product Status that you want to add (True/False)(1 or 0 acceptable) : ");
            ////productStatus = bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=CAN-TOKHAY-MASA\\CANTOKHAY; Initial Catalog=BootcampDb; User ID=sa; Password=230491Can.;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery(); // method is used to execute SQL commands that saves data to the database without any query filter. Means Save changes to the database.
            //connection.Close();

            //Console.WriteLine("Product Added Successfully!");

            #endregion

            #region Read Products

            //SqlConnection connection = new SqlConnection("Data Source=CAN-TOKHAY-MASA\\CANTOKHAY; Initial Catalog=BootcampDb; User ID=sa; Password=230491Can.;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //connection.Close();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Delete a Product

            //int productId;
            //Console.Write("Product Id that you want to delete : ");
            //productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=CAN-TOKHAY-MASA\\CANTOKHAY; Initial Catalog=BootcampDb; User ID=sa; Password=230491Can.;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("delete from TblProduct where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery(); // Save changes to the database.
            //connection.Close();

            //Console.WriteLine("Product Deleted Successfully!");

            #endregion

            #region Update a Product

            int productId;

            Console.Write("Product Id that you want to update : ");
            productId = int.Parse(Console.ReadLine());

            Console.Write("Product Name that you want to update : ");
            string productName = Console.ReadLine();

            Console.Write("Product Price that you want to update : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=CAN-TOKHAY-MASA\\CANTOKHAY; Initial Catalog=BootcampDb; User ID=sa; Password=230491Can.;");
            connection.Open();
            SqlCommand command = new SqlCommand("update TblProduct set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId", connection); //if productId didnt filtered, all products will be updated. WARNING! ACHTUNG!
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery(); // Save changes to the database.
            connection.Close();

            Console.WriteLine("Product Updated Successfully!");

            #endregion

            Console.Read();
        }
    }
}
