using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            RemoveWhiteSpaces(str);
            Console.ReadLine();
        }

        private static void RemoveWhiteSpaces(string str)
            => Console.WriteLine(str?.Replace(" ", "").Replace("\t", "").Replace("\n","").Replace("\r",""));
    }
}
