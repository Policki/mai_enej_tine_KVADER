using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace vaja_6_2
{
    public class Kvader
    {
        private double a;
        private double b;

        public Kvader()
        {
            a = 1;
            b = 1;
        }

        public Kvader(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Nastavi()
        {
            Console.Write("Vnesi prvo stranico: ");
            double a= double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Vnesi drugo stranico: ");
            double b = double.Parse(Console.ReadLine());
            this.a = a;
            this.b = b;
        }
        public void VrniObseg()
        {
            double o = (2 * a) + (2 * b);
            Console.WriteLine("Obseg Kvadra je: {0}", o);
        }

        public void VrniPloscino()
        {
            double p = a * b;
            Console.WriteLine("Ploščina Kvadra je: {0}", p);
        }
    }
}
