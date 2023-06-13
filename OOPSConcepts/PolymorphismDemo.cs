using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    //Method Overloading
    public class PolymorphismDemo
    {
        public int Sum(int a,int b)
        {
            return a + b;
        }
        public int Sum(int a, int b, int c)
        {
            return a + b+ c;
        }
    }
    //Method Overriding
    public class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Animal Makes a sound");
        }
    }
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    public class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Pig says wee wee");
        }
    }
   
}
