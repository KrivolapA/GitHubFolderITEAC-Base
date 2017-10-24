using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            object o = i;
            Circle c = new Circle("First circle", 10);
            Shape sampleShape = c;
            c.PrintId();
            sampleShape.PrintId();
            Console.WriteLine(sampleShape);
            Console.ReadLine();
        }
    }
}
