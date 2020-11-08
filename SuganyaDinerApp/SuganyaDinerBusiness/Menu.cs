using SuganyaDinerBusiness.DinerTableAdapters;
using System;
using System.Collections.Generic;
using System.Text;
using static SuganyaDinerBusiness.Diner;

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

        public static List<Menu> GetMenus()
        {
            var menus = new List<Menu>();
            var menuTableAdapter = new MenuTableAdapter();
            var data = menuTableAdapter.GetData();
            foreach (MenuRow item in data)
            {
                var menu = new Menu();
                menu.Name = item.Name;
                menu.MenuItems = MenuItem.GetMenuItems(item.ID);
                menus.Add(menu);
            }
            return menus;
        }
    }
}
