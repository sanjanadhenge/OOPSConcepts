using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Method Overloding ==>");
            PolymorphismDemo polymorphismDemo = new PolymorphismDemo();
            int result1 = polymorphismDemo.Sum(5, 8);
            Console.WriteLine(result1);
            int result2 = polymorphismDemo.Sum(5, 8,15);
            Console.WriteLine(result2);
            Console.WriteLine("Method Overriding ==>");
            Animal animal = new Animal();
            animal.AnimalSound();
            Dog dog = new Dog();
            dog.AnimalSound();
            Pig pig = new Pig();
            pig.AnimalSound();

        }
      

    }
}

