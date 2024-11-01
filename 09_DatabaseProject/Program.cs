using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Bootcamp Category - Product Info System *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1. Categories");
            Console.WriteLine("2. Products");
            Console.WriteLine("3. Orders");
            Console.WriteLine("4. Close Program");
            Console.Write("Please Enter Table Number : ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------");

            //Ado.Net
            SqlConnection connection = new SqlConnection("Data Source=CAN-TOKHAY-MASA\\CANTOKHAY; Initial Catalog=BootcampDb; User ID=sa; Password=230491Can.;");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
