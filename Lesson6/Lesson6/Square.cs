using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Square : Shape
    {
        private int side;
        public Square(string id, int side):base(id)
        {
            this.side = side;
        }

    }
}
