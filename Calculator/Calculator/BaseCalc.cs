using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SomeBase
    {
        public SomeBase()
        {
            Console.WriteLine("SomeBase");
        }
    }
    
    class BaseCalc:SomeBase
    {
        protected double value;
        public double Value
        {
            get
            {
                return value;
            }
        }
        public BaseCalc()
        {
            Console.WriteLine("In BaseCalc");
            value = 1;
        }
        public BaseCalc(double value)
        {
            this.value = value;
        }
        public void Plus(double operand)
        {
            value += operand;
        }
        public void Minus(double operand)
        {
            value -= operand;
        }
        public void Mult(double operand)
        {
            value *= operand;
        }
        public void Div(double operand)
        {
            if(operand != 0)
                value /= operand;
        }
        public void SetValue(double value)
        {
            this.value = value;
        }
        public static double operator + (BaseCalc calc, double oper)
        {
            calc.Plus(oper);
            return calc.Value;
        }
        /*public static double operator + (double oper, BaseCalc calc)
        {
            return calc + oper;
        }*/
        public static double operator + (BaseCalc calc1, BaseCalc calc2)
        {
            calc1.Plus(calc2.Value);
            return calc1.Value;
        }
        public static implicit operator int (BaseCalc b)
        {
            return (int)b.Value;
        }
    }
}
