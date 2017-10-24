using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Shape
    {
        public Shape(String id)
        {
            this.id = id;
        }
        String id;
        public void PrintId()
        {
            Console.WriteLine("Id of this shape is {0}", id);
        }
    }
}
