using System;
using System.Collections.Generic;
using System.Text;

namespace SuganyaDinerApp
{
    class MenuItem
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
    }
}
