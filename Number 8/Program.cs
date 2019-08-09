using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_8
{
    class Program
    {

        static void GenerateRandomNo()
        {
            Random _rdm = new Random();

            for (int i = 1; i < 1000; i++)
            {
                int _min = 1000;
                int _max = 9999;
                int myResult = _rdm.Next(_min, _max);
                Console.WriteLine(myResult);

            };
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            GenerateRandomNo();
        }
    }
}
