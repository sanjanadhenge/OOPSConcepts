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
            //single inheritnce
            Dog dog = new Dog();
            dog.Animalname();
            dog.Animal();
            //Multilevel inheritance
            Animalsound animalsound = new Animalsound();
            animalsound.soundName();
            animalsound.Animalname();
            animalsound.Animal();
            //hierarchical inheritance
            Pig pig = new Pig();
            pig.Animal();
            pig.Name();
            //Mutiple inheritance
            Rectangle rect = new Rectangle(5, 10, "blue");
            Console.WriteLine("Area of rectangle: " + rect.GetArea());
            Console.WriteLine("Color of rectangle: " + rect.GetColor());
        }


    }
}

