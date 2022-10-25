using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Дом: Недвижимость
    {
        public int meters;

        public Дом(int pPrice, string pName, int pMetest) : base(pPrice, pName)
        {
            meters = pMetest;
        }
        override public void GetInfo()
        {
            Console.WriteLine(name + " " + price+" "+meters);
        }
    }
}
