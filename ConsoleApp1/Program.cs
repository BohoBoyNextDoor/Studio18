using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// MenuItem stores the category as an int to allow sorting by type, eg appetizers are 1,etc...
        /// </summary>
        private class MenuItem
        {

            public int Price { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public DateTime DateAdded { get; set; }
            public string DishName { get; set; }

            public MenuItem(string DishNameNR, int PriceNR, string DescriptionNR, string CategoryNR, DateTime DateAddedNR)
            {
                DishName = DishNameNR;
                Price = PriceNR;
                Description = DescriptionNR;
                Category = CategoryNR;
                DateAdded = DateAddedNR;
            }



        }

        private static class Menu
        { 
        //create lists, for loop, writeline

        }
        
        
        
        
        
        
        
        static void Main(string[] args)
        {
            List<MenuItem> MenuList = new List<MenuItem> { };
            MenuItem BabaGanoush = new MenuItem("Baba Ganoush", 25, "An acidic and refreshing dip created from roasted eggplant" +
                "bright lemon, and fresh herbs. Served with pita", "App", new DateTime(2021,06,28));
            MenuItem Hummus = new MenuItem("Hummus", 23, "An earthy blend of hearty chickpeas, zesty citrus, and exotic spices" +
                "served with pita", "App", new DateTime(2021, 06, 28));
            MenuItem TofuCurry = new MenuItem("Tofu Curry", 36, "Marinated tofu simmered alongside locally sourced produce. Served" +
                " with jasmine rice. Vegan", "Entre", new DateTime(2021, 06, 28));
            MenuItem Salad = new MenuItem("Salad", 33, "This elevated salad contains organic rahubarb in tandem with" +
                " rainbow radishes atop a kale bed and lightly dressed with raspberry vinegrette. ", "entre", new
                DateTime(2021,06,28));
            MenuItem StrawberriesRomanoff = new MenuItem("Strawberries Romanoff", 18, "this dish marries farm fresh straberries and creme, all" +
                "with earthy spices to bring us back down.", "Des", new DateTime(2021, 06, 28));
            MenuItem Baklava = new MenuItem("Baklava", 20, "Wafer-thin filo dough layered with localhoney and Iranian pistachios.",
                "des", new DateTime(2021, 06, 28));
            MenuList.Add(BabaGanoush);
            MenuList.Add(Hummus);
            MenuList.Add(TofuCurry);
            MenuList.Add(Salad);
            MenuList.Add(StrawberriesRomanoff);
            MenuList.Add(Baklava);
            foreach (MenuItem item in MenuList)
            {
                Console.WriteLine($"{item.DishName} {item.Category} {item.Description} {item.Price}");
            }
            ;
            
        }
    }
}
