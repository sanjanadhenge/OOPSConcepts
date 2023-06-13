using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    //static Method
    public static class MethodTypes
    {
       public static void Multiply()
        {
            int a = 5, b = 9;
            Console.WriteLine("Multiplication of two number is => " + a * b);
        }
                
    }
    public class Nonstatic
    {
        public int calculation(int x, int y)
        {
            int val = x * y;
            return val;
        }
    }
    
}
    
