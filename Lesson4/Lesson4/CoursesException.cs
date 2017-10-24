using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class CoursesException : Exception
    {
        public int currentNumberOfStudents { get; set; }
    }
}
