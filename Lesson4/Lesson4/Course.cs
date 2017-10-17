using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Course
    {
        public string Name { get; }
        StudentCourseEnrollment[] studentRecords;
        static int totalStudents;
        const int maxStudentsPerCourse = 20;
        const int maxStudentsTotal = 100;
        public int StudentsAtCourse { get; private set; } = 0;
        public Course(string Name)
        {
            this.Name = Name;
        }
        public Course(string Name, Student[] students) : this(Name)
        {           
            studentRecords = new StudentCourseEnrollment[maxStudentsPerCourse];
            for(int i = 0; i< students.Length; i++)
            {
                studentRecords[i] = new StudentCourseEnrollment(students[i], this);
            }
            StudentsAtCourse = students.Length;
        }
    }
}
