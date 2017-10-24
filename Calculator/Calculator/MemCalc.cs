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
