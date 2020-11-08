using SuganyaDinerBusiness;
using System;

namespace SuganyaDinerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            MenuItem.SaveMenuItem("Kabab", "Chicken 65", 45, 1);
            MenuItem.SaveMenuItem("Mazza", "Mango juice", 65, 2);
            Console.WriteLine("after adding two items.");
            Print();
        }
        public static void Print()
        {
            var menus = Menu.GetMenus();
            foreach (var menu in menus)
            {
                Console.WriteLine($"{menu.Name}");
                foreach (var menuItem in menu.MenuItems)
                {
                    Console.WriteLine($"{menuItem.Name}, {menuItem.Description}, {menuItem.Cost}");
                }
            }
        }
    }
}
