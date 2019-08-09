using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_9_Teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];
            Random rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = rand.Next(100, 1000);
                while (nums.Contains(temp))
                {
                    temp = rand.Next(100, 1000);
                }
                nums[i] = temp;
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
