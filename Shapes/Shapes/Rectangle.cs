using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape, IComparable, IFormattable
    {
        public double side { get; private set; } = 10;
        public Rectangle()
        { }

        public Rectangle(double side)
        {
            this.side = side;
        }
        public override double Square()
        {
            return side * side;
        }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Side = {0}",side);
        }
        public int CompareTo(Object o)
        {
            return (int)(side - ((Rectangle)o).side);
        }
        public string ToString(string format, IFormatProvider provider)
        {
            if (format == "SD")
                return "Side = " + side;
            if (format == "FULL")
                return "Rectangle with Side = " + side + " and square = " + Square();
            return "Rectangle";
        }
    }
}
