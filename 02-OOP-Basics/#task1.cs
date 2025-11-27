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
            Person per1 = new Person("Luka", "Aracic", 23);
            Person per2 = new Person("Gabriel", "Matkovic", 25);
            Person per3 = new Person("Jugović", "Josip", 28);

            per1.introduceYsf();
            per2.introduceYsf();
            per3.introduceYsf();


            Console.ReadKey();
        }
    }

    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int age { get; set; }

        public Person (string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void introduceYsf()
        {
            Console.WriteLine($"Hi I am {firstName} {lastName} and I have {age} years");
        }
    }
}
