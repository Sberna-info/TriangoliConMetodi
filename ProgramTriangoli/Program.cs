using System;
using ClassTriangoli;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTriangoli
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            double l1 = Class1.Lato();
            double l2 = Class1.Lato();
            double l3 = Class1.Lato();
            string triangolo = Class1.OutputTrangolo(l1, l2, l3);
            double? perimetro = Class1.Perimetro(l1, l2, l3);
            Console.ReadLine();
        }
    }
}
