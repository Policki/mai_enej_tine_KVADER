using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prvi naj ima širino in višino enako 3,
            //drugi pa naj ima širino 6 in višino 4.
            //Z uporabo metod na standardni izhod izpiši njuni ploščini.
            Kvader k1 = new Kvader(3, 3);
            Kvader k2 = new Kvader(6, 4);

            Console.WriteLine("Kvader 1");
            k1.VrniObseg();
            k1.VrniPloscino();
            Console.WriteLine("");
            Console.WriteLine("Kvader 2");
            k2.VrniObseg();
            k2.VrniPloscino();

            Console.ReadKey(true);
        }
    }
}
