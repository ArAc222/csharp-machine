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
            Student stud1 = new Student("Luka", "Aracic", 27, 4.56);
            Professor prof = new Professor("Peter", "Griffin", 44, "Psychology");

            stud1.introduceYsf();
            prof.introduceYsf();


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

        public virtual void introduceYsf()
        {
            Console.WriteLine($"Hi I am {firstName} {lastName} and I have {age} years");
        }
    }

    class Student : Person
    {
        public double averageGrades { get; set; }

        public Student (string firstName, string lastName, int age,  double averageGrades) : base (firstName, lastName, age)
        {
             this.averageGrades = averageGrades;
        }

        public override void introduceYsf()
        {
            Console.WriteLine($"Hi I am {firstName} {lastName} and I got {averageGrades} average point from my grades.");
        }

    }

    class Professor : Person
    {
        public string subject { get; set; }

        public Professor(string firstName, string lastName, int age, string subject) : base(firstName, lastName, age)
        {
            this.subject = subject;
        }

        public override void introduceYsf()
        {
            Console.WriteLine($"Hello my name is professor {firstName} and I teach the {subject} ");
        }
    }
}
