using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintOddNumbers();
            Console.ReadLine();
        }

        private static void PrintOddNumbers()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
