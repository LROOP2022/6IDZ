using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Машина:Недвижимость
    {
        public int maxSpeed;

        public Машина(int pPrice, string pName, int pMaxSpeed) : base(pPrice, pName)
        {
            maxSpeed = pMaxSpeed;
        }
        override public void GetInfo()
        {
            Console.WriteLine(name + " " + price+" "+maxSpeed);
        }
    }
}
