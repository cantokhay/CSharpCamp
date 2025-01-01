namespace Bootcamp601.ConnStr
{
    public static class PostgreConnectionString
    {
        public static string ConnStr()
        {
            return "Server=localhost;port=5432;Database=BootcampCustomerDb;user Id=postgres;Password=password1234";
        }
    }
}
