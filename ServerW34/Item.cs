using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerW34
{
    class Item
    {
        private string Name;
        private int Starting_Price;
        private int Current_Price;

        public Item(string name, int sp)
        {
            Name = name;
            Starting_Price = sp;
            Current_Price = sp;
        }
    }
}
