using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbersSteping5();
            Console.ReadLine();
        }

        private static void PrintNumbersSteping5()
        {
            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine(i);
            }
        }
    }
}
