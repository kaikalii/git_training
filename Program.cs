using System;
using System.Collections.Generic;
using System.Linq;

///***********************************************
/// Git Training - CS409
///***********************************************
namespace git_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everyone!");
            Console.WriteLine("Hello everyone!");

            Console.WriteLine("Kai was here");

            Console.WriteLine("Dog");
            Console.WriteLine("Cat");
            {
                foreach (var i in Fibonacci().Take(20))
                {
                    Console.WriteLine(i);
                }

            }
        }
        private static IEnumerable<int> Fibonacci()
        {
            int current = 1, next = 1;

            while (true)
            {
                yield return current;
                next = current + (current = next);
            }
        }
    }
}