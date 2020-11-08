using System;
using System.Collections.Generic;
using System.Text;

namespace SuganyaDinerBusiness
{
    public class Menu
    {
        public Menu()
        {
            this.MenuItems = new List<MenuItem>();
        }
        public string Name { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public void AddMenutem(string Name,string Description, int Cost)
        {
            MenuItem item = new MenuItem();
            item.Name = Name;
            item.Description = Description;
            item.Cost = Cost;
            MenuItems.Add(item);
        }
    }
}
