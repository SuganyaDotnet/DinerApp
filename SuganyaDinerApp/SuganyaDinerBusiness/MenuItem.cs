using SuganyaDinerBusiness.DinerTableAdapters;
using System;
using System.Collections.Generic;
using System.Text;
using static SuganyaDinerBusiness.Diner;

namespace SuganyaDinerBusiness
{
    public class MenuItem
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Cost
        {
            get { return _Cost; }
            set
            {
                if (value > 0)
                {
                    _Cost = value;
                }
                else
                {
                    throw new Exception("value can't be empty");
                }
            }
        }
        private int _Cost;
        public static void SaveMenuItem(string name, string description, int cost, int menuId)
        {
            var menuItemTableAdapter = new MenuItemTableAdapter();
            menuItemTableAdapter.InsertMenuItem(name, description, cost, menuId);
        }
        public static List<MenuItem> GetMenuItems(int menuId)
        {
            var menuitems = new List<MenuItem>();
            var menuItemTableAdapter = new MenuItemTableAdapter();
            //var data=menuItemTableAdapter.GetData();
            var data = menuItemTableAdapter.GetDataBy(menuId);
            foreach (MenuItemRow item in data.Rows)
            {
                var menuItem = new MenuItem();
                menuItem.Name = item.Name;
                menuItem.Description = item.Descrption;
                menuItem.Cost = item.Cost;
                menuitems.Add(menuItem);
            }
            return menuitems;
        }
    }
}
