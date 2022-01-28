using System.Collections.Generic;

namespace Common
{
    public static class Global
    {
        public static string ApplicationName { get; } = "MyApp";

        public static string AdminRoleName { get; } = "Admin";

        public static AppTitles Titles = new AppTitles { Home = "Home Page", Privacy = "Privacy", Products = "All Products", ProductDetails = "Details of Product" };
    }

    public class AppTitles
    {
        public string Home { get; set; }
        public string Privacy { get; set; }
        public string Products { get; set; }
        public string ProductDetails { get; set; }
    }
}
