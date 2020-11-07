using System;

namespace SuganyaDinerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Name = "Suganya Diner";
            MenuItem menuItem = new MenuItem();
            menuItem.Name = "Chicken Briyani";
            menuItem.Description = "Biriyani with chicken";
            menuItem.Cost = 100;
            menu.MenuItems.Add(menuItem);
        }
    }
}
