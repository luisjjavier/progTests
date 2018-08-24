using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pharase = Console.ReadLine();

            List<string> list =  pharase.Split(' ').ToList();
            list.Reverse();
            Console.WriteLine(string.Join(" ",list));

            Console.ReadLine();
        }
    }
}
