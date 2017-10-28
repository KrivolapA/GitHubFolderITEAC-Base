using System;
using static System.Console;
namespace Shapes
{
    class Program
    {
        static double CalcTotalSquare(Shape[] shapes)
        {
            double result = 0;
            foreach(Shape s in shapes)
            {
                result += s.Square();
            }
            return result;
        }
        static void Main(string[] args)
        {
            Shape s = new Rectangle();
            WriteLine("{0:FULL}",s);
            Rectangle[] rectangles = new Rectangle[] {new Rectangle(7), new Rectangle(2), new Rectangle(10), new Rectangle(5) };
            Array.Sort(rectangles);
            foreach (Rectangle r in rectangles)
                WriteLine(r.side);
            WriteLine(s.Square());
            s.Draw(); 
            WriteLine(((Rectangle)s).Square());
            s = new EmptyShape();
            WriteLine(s.Square());
            ReadLine();
        }
    }
}
