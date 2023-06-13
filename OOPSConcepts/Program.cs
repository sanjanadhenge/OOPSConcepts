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
            //Static Method
            MethodTypes.Multiply();
            //Non-Static Method
            Nonstatic nonstatic = new Nonstatic();
            int result=nonstatic.calculation(5, 10);
            Console.WriteLine(result);
        }
      

    }
}

