using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MemCalc:BaseCalc
    {
        protected double memValue;
        public MemCalc()
        {
            Console.WriteLine("In MemCalc");
        }
        public void SetMem()
        {
            memValue = value;
        }
        public void GetMem()
        {
            value = memValue;
        }
        
    }
}
