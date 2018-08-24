using System;

namespace exercise_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintNumber1To100();
            Console.ReadLine();
        }

        private static void PrintNumber1To100()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
