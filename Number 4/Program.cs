using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_4
{
    class Program
    {
        static void Product(int input, int input2)
        {
            int result = input * input2;

            Console.WriteLine(input + " x " + input2 + " = " + result);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a another number:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Product(input, input2);
        }
    }
}
