using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_9
{
    class Program
    {
        static int size = 100;
        static void Main(string[] args)
        {
            int[] nums = new int[size];
            Random rand = new Random();

            int i;
            for (i = 0; i < nums.Length; i++)
            {
                int next;
                while (true)
                {
                    next = rand.Next(100, 1000);
                    if (!Contains(nums, next)) break;
                }
                nums[i] = next;
                Console.Write($"{nums[i]} ");
            }

            Console.ReadLine();
        }

        static bool Contains(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) return true;
            }
            return false;
        }

    }
}

