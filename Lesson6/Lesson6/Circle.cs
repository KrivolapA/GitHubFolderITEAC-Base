using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Circle : Shape
    {
        private int radius;
        public Circle(string id, int radius):base(id)
        {
            this.radius = radius;
        }
    }
}
