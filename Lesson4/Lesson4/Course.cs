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
            studentRecords = new StudentCourseEnrollment[maxStudentsPerCourse];
        }
        public Course(string Name, Student[] students) : this(Name)
        {           
            studentRecords = new StudentCourseEnrollment[maxStudentsPerCourse];
            try {
                for (int i = 0; i < students.Length; i++)
                {
                    AddStudent(students[i]);
                    //studentRecords[i] = new StudentCourseEnrollment(students[i], this);
                }
                StudentsAtCourse = students.Length;
            }
            catch(CoursesException e)
            {
                
            }
            
           
        }
        public bool AddStudent(Student st)
        {
            if (StudentsAtCourse < maxStudentsPerCourse)
            {
                studentRecords[StudentsAtCourse++] = new StudentCourseEnrollment(st, this);
                totalStudents++;
                return true;
            }
            else
                throw new CoursesException() {currentNumberOfStudents = totalStudents };
            
        }
        public int AddStudents(Student[] students)
        {
            int numProcessed = 0;
            foreach(Student st in students)
            {
                if (AddStudent(st))
                    numProcessed++;
            }
            return numProcessed;
        }
        public void ArrangeRaitnig()
        {
            Array.Sort(studentRecords, 0, StudentsAtCourse);
        }
        public int this[String FullName]
        {
            get
            {
                foreach (StudentCourseEnrollment se in studentRecords)
                    if (se.student.FullName("") == FullName)
                        return se.points;
                return -1;
            }
        }
    }
}
