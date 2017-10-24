using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class StudentCourseEnrollment
    {
        public Student student { get; set; }
        Course course;
        public int points { get; set; }
        public StudentCourseEnrollment(Student student, Course course)
        {
            this.student = student;
            this.course = course;
            points = 10;
        }
    }
}
