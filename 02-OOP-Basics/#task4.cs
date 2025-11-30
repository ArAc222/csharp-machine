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
            List<Person> list = new List<Person>();

            list.Add(new Person("Luxyz", "McCoder", 144));
            list.Add(new Student("Pamela", "Anderson", 32, 4.22));
            list.Add(new Professor("Mrs", "Abignale", 58, "History"));

            foreach(var per in list)
            {
                per.introduceYsf();
            }


        }
    }

    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int age { get; private set; }

        public Person (string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            setYears(age);
        }

        public virtual void introduceYsf()
        {
            Console.WriteLine($"Hi I am {firstName} {lastName} and I have {age} years");
        }

        public void setYears(int age)
        {
            if(age  < 0 || age > 120)
            {
                throw new Exception("Unsupported age entered!");
                
            }
            else
            {
                this.age = age;
            }
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
