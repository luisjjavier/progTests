using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEvenNumbers();
            Console.ReadLine();
        }

        private static void PrintEvenNumbers()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
