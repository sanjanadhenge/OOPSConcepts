using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public abstract class Demo
    {
        public abstract  void Add();
        public void Diffrence()
        {
            Console.WriteLine("Enter 1st Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a - b;
            Console.WriteLine("Diffrence of two number is => " + c);
        }
    }
    public class ChildClass : Demo
    {
        public override void Add()
        {
            Console.WriteLine("Enter 1st Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Sum of two number is => " + c);
        }
    }
}