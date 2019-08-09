using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_5
{
    class Program
    {
        static void Multiply(int input)
        {
            for (int i = 1; i < 11; i++)
            {
                int result = input * i;
                Console.WriteLine(input + " x " + i + " = " + result);
                Console.ReadLine();
            };
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            Multiply(input);

        }
    }
}
