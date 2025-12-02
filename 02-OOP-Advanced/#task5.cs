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
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog("Rex", 8));
            animals.Add(new Cat("Missy", 5));

            foreach(var anm in animals)
            {
                anm.MakeSound();
                
                if(anm is IMoving mv)
                {
                    mv.Move();
                }
            }


            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public string name {  get; set; }
        public  int age { get; set; }

        public abstract void MakeSound();
    }

    public class Dog : Animal, IMoving
    {
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public void Move()
        {
            Console.WriteLine("Dog is moving!");
        }
    }

    public class Cat : Animal, IMoving
    {
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public void Move()
        {
            Console.WriteLine("Cat is moving!");
        }
    }

    public interface IMoving
    {
        void Move();
    }
}
