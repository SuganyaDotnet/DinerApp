using System;
using System.Collections.Generic;
using System.Text;

namespace SuganyaDinerApp
{
    class Menu
    {
        public Menu()
        {
            this.MenuItems = new List<MenuItem>();
        }
        public string Name { get; set; }
        public List<MenuItem> MenuItems { get; set; }
    }
}
