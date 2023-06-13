using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class VariableTypes
    {
        //static variable
        public static int Salary = 25000;
        //Non-static variable
        int age = 30;
        // Constant variable
        const string name = "ABC";
        //Readonly
        public readonly string phoneNumber = "9513568744";
        public void DisplayData()
        {
            Console.WriteLine("Name => " + name);
            Console.WriteLine("Age => " + age);
            Console.WriteLine("Salary => " + Salary); 
            Console.WriteLine("Phone Number => " + phoneNumber);

        }
                
    }
    
}
    
