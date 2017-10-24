using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcUI
    {
        private BaseCalc calculator;
        public CalcUI(BaseCalc calculator)
        {
            this.calculator = calculator;
        }
        public void PrintMenu()
        {
            Console.WriteLine("1.+");
            Console.WriteLine("2.-");
            if(calculator is MemCalc)
            {
                Console.WriteLine("5. save in mem");
            }
        }
    }
}
