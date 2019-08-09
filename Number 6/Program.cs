using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_6
{
    class Program
    {
        static void CircleCalc(double radius)
        {
            double A = 3.14 * (radius * radius);
            double B = 2 * 3.14 * radius;

            Console.WriteLine("Area: " + A);
            Console.WriteLine("Perimeter: " + B);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            CircleCalc(radius);
            Console.ReadLine();
        }
    }
}
