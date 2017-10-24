using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class ModClass
    {
        public static int Mod(this BaseCalc calc, int oper)
        {
            return (int)calc.Value % oper;
        }
    }
}
