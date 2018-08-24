using System;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            ReverseString(str);

            Console.ReadLine();
        }

        private static void ReverseString(string str)
            => Console.WriteLine(string.Join("", str?.Reverse()));
    }
}

