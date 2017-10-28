using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class RectangleWithText:Rectangle
    {
        string text;
        public override double Square()
        {
            return 2*side * side;
        }
    }
}
