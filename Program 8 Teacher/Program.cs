using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_8_Teacher
{
    class Program
    {
        static int size = 1000;
        static void Main(string[] args)
        {
            int [] nums = new int[size];
            Random rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1000, 10000);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
