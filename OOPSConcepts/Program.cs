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
            MethodTypes methodTypes = new MethodTypes();
            methodTypes.Division(100, 10);
            PassByRef v1 = new PassByRef(12);
            PassByRef v2 = new PassByRef(22); //Breakpoint
            v2 = v1;
            Console.WriteLine(v1.value);
            Console.WriteLine(v2.value);
            Console.ReadLine();
        }
      

    }
}

