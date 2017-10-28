using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        int x, y;
        string Name;
        public abstract double Square();
        
        public virtual void Draw()
        {
            Console.WriteLine("Figure {0} x:{1} y:{2}", Name, x, y);
        }
    }
}
