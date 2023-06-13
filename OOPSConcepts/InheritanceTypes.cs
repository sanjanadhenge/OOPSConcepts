using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    // single inheritance
    public class InheritanceTypes
    {
      public void Animal()
        {
            Console.WriteLine("Animal");
        }
    }
    public class Dog : InheritanceTypes
    {
        public void Animalname()
        {
            Console.WriteLine("Dog");
        }
    }
    //Multilevel inheritance
    public class Animalsound : Dog
    {
        public void soundName()
        {
            Console.WriteLine("Bark");
        }
    }
    //hierarchical inheritance
    public class Pig : InheritanceTypes
    {
        public void Name()
        {
            Console.WriteLine("Pig");
        }
    }
    //Mutiple inheritance
    interface IShape
    {
        double GetArea();
    }

    interface IColor
    {
        string GetColor();
    }

    class Rectangle : IShape, IColor
    {
        private double length;
        private double breadth;
        private string color;

        public Rectangle(double length, double breadth, string color)
        {
            this.length = length;
            this.breadth = breadth;
            this.color = color;
        }

        public double GetArea()
        {
            return length * breadth;
        }

        public string GetColor()
        {
            return color;
        }
    }
}
    
