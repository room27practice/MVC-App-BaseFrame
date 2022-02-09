using System.Collections.Generic;

namespace Common
{
    public static class Global
    {
        public static string ApplicationName { get; } = "MyApp";

        public static string AdminRoleName { get; } = "Admin";

        public static AppTitles Titles = new AppTitles { Home = "Home Page", Privacy = "Privacy", Products = "All Products", ProductDetails = "Details of Product" };

        public static string SQLString => sqlConnectionStrings[connectionStringToUse];

        //Choose your connection that should be used upon running the app
        private static string connectionStringToUse = "HristovHomePc";
        //Register here all connections to remoteDB to your DB to all kinds of DB-s
        private static IDictionary<string, string> sqlConnectionStrings = new Dictionary<string, string>()
        {
            ["HristovHomePc"] = "Server=DESKTOP-9H4U8QH\\SQLEXPRESS;Database=T34;Trusted_Connection=True;MultipleActiveResultSets=true",
            ["MyConnection"] = "con2",
            ["HristovSchoolPc"] = "con3",
        };
    }







    public class AppTitles
    {
        public string Home { get; set; }
        public string Privacy { get; set; }
        public string Products { get; set; }
        public string ProductDetails { get; set; }
    }
}
