using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCalc myCalculator = new MemCalc();
            myCalculator.SetValue(2);
            myCalculator.Plus(3);
            ((MemCalc)myCalculator).SetMem();
            myCalculator.Minus(2);
            ((MemCalc)myCalculator).GetMem();
            Console.WriteLine(myCalculator.Value);
            CalcUI c = new CalcUI(new MemCalcWithPow());
            c.PrintMenu();
            BaseCalc calc = new BaseCalc();
            calc.SetValue(5.5);
            calc.Mod(2);
            ModClass.Mod(calc, 2);
            double result = 3+calc+4+5;
            Console.WriteLine(result); 
            Console.WriteLine(calc.Value);
            Console.ReadLine();
        }
    }
}
