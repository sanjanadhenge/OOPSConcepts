using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class EncapsulationDemo
    {
       
            private int balance;
            public int myBalance
            {
                get { return balance; }
        private set
                {
                    if (balance < 0)
                    {
                        balance = 10000;
                    }
                }
            }
        }
    
}
