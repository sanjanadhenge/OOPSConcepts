using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    //pass by value
    public class MethodTypes
    {
      
     public void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
        }
       
    }
    //pass by Ref
    class PassByRef
    {
        public int value
        {
            get;
            set;
        }
        public PassByRef(int passbyref)
        {
            this.value = passbyref;
        }
    }
}
    
