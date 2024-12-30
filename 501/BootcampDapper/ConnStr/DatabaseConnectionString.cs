using System.Data.SqlClient;

namespace BootcampDapper.ConnStr
{
    public static class DatabaseConnectionString
    {
        public static SqlConnection ConnStr()
        {
            return new SqlConnection("Data Source=CAN-TOKHAY-MASA\\CANTOKHAY;Integrated Security=True;initial Catalog=EgitimKampi501Db");
        }
    }
}
