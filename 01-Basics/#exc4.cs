using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Excersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Plese enter enter first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Plese enter enter second number:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(sumUp(a,b));

            string name;
            Console.WriteLine("Please enter a name:");
            name = Console.ReadLine();
            sayHi(name);

            Console.WriteLine("Enter a length of a array:");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter elements of an array:");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Average of the array is: {Average(array)}");

            Console.ReadKey();
        }

        static double sumUp(int a, int b)
        {
            return a + b;
        }

        static void sayHi(string name)
        {
            Console.WriteLine(name);
        }

        static double Average(int[] numbers)
        {
            double sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }
    }
}
