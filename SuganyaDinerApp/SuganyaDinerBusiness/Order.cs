using System;
using System.Collections.Generic;
using System.Text;

namespace SuganyaDinerBusiness
{
    public class Order
    {
        public List<MenuItem> items = new List<MenuItem>();
        public int Total {
            get
            {
                int total = 0;
                foreach (var item in items)
                {
                    total = total + item.Cost;
                }
                return total;
            }
        }
    }
}
