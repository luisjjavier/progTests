using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string pharase = Console.ReadLine();
            var balanced = true;
            Stack<char> stack = new Stack<char>();

            string onlyBrackets =  string.Join("", pharase.Where(c => c == '(' || c == ')'));
            for (int i = 0; i < onlyBrackets.Length && balanced; i++)
            {
                char c = onlyBrackets[i];

                if (c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        balanced = false;
                    }
                    else
                    {
                        stack.Pop();
                    }

                }
            }

            if (balanced && stack.Count == 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadLine();
        }
    }
}
