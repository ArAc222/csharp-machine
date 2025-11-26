using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter a whole number: ");
            num1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num1; i++)
            {
                if (i % 3 == 0)
                {
                    if(i % 5 == 0)
                    {
                        Console.WriteLine($"{i}FizzBuzz");
                        continue;
                    }
                    Console.WriteLine($"{i}Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
