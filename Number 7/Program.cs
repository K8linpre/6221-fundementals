using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_7
{
    class Program
    {
        static void SwapNum(ref int x, ref int y)
        {
            int swap = x;
            x = y;
            y = swap;
        }
        static void Main(string[] args)
        {
            int A = 10;
            int B = 20;

            Console.WriteLine("Before Swap: " + "A = " + A + " B = " + B);
            Console.ReadLine();

            SwapNum(ref A, ref B);

            Console.WriteLine("After Swap: " + "A = " + A + " B = " + B);
            Console.ReadLine();
        }
    }
}
