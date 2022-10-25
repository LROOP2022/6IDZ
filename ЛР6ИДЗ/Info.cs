using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Info<T> where T : Недвижимость
    {

        public static void GetFullInfo(T geo)
        {
            geo.GetInfo();
        }

        public static void GetPrice(T geo)
        {
            Console.WriteLine(geo.price);
        }
    }
}
