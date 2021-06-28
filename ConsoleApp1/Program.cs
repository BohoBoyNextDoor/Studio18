using System;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// MenuItem stores the category as an int to allow sorting by type, eg appetizers are 1,etc...
        /// </summary>
        private class MenuItem
        {
            private readonly int price;
            private readonly string description;
            private readonly int category;
            private readonly DateTime dateAdded;

            public MenuItem(int Price, string description, int category, DateTime DateAdded)
            {
                this.Price = this.Price;
                Description = Description;
                Category = Category;
                DateAdded = DateAdded;
            }

            private int Price { get; set; }
            private string Description { get; set; }
            private int Category { get; set; }
            private DateTime DateAdded { get; set; }
            
          
        }

        private static class Menu
        { 
        
        }
        
        
        
        
        
        
        
        static void Main(string[] args)
        {
            MenuItem BabaGanoush = new MenuItem(25, "An acidic and refreshing dip created from roasted eggplant" +
                "bright lemon, and fresh herbs. Served with pita", 1, new DateTime(2021,06,28));
            MenuItem Hummus = new MenuItem(23, "An earthy blend of hearty chickpeas, zesty citrus, and exotic spices" +
                "served with pita", 1, new DateTime(2021, 06, 28));
            MenuItem TofuCurry = new MenuItem(36, "Marinated tofu simmered alongside locally sourced produce. Served" +
                " with jasmine rice. Vegan", 2, new DateTime(2021, 06, 28));
            MenuItem Salad = new MenuItem(33, "This elevated salad contains organic rahubarb in tandem with" +
                " rainbow radishes atop a kale bed and lightly dressed with raspberry vinegrette. ", 2, new
                DateTime(2021,06,28));
            MenuItem StrawberriesRomanoff = new MenuItem(18, "this dish marries farm fresh straberries and creme, all" +
                "with earthy spices to bring us back down.", 3, new DateTime(2021, 06, 28));
            MenuItem Baklava = new MenuItem(20, "Wafer-thin filo dough layered with localhoney and Iranian pistachios.",
                3, new DateTime(2021, 06, 28));

            
        }
    }
}
