using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Programm
    {
        static void Main(string[] args)
        {
            Машина car = new Машина(3500000, "honda", 290);
            Дом house = new Дом(28000000, "Дом", 94);
            Info<Машина>.GetFullInfo(car);
            Info<Дом>.GetFullInfo(house);
            Info<Недвижимость>.GetPrice(car);
        }
    }
}
