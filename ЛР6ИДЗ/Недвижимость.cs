using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Недвижимость
    {
        public int price;
        public string name;
        public Недвижимость(int pPrice, string pName)
        {
            price = pPrice;
            name = pName;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine(name+" "+price);
        }
    }
}
