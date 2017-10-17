using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int y = x ?? 10;
            Course[] allCourses = new Course[10];
            int numCourses = 0;
            Student goodStudent = Student.createStudent();
            Student badStudent = new Student { Age = 20 };
            badStudent.Age = 10;
            if(badStudent != null)
            {
                goodStudent.Age = badStudent?.Age ?? 10;
            }
            StudentStruct stStruct;
            stStruct.Age = 13;
            allCourses[numCourses++] = new Course("first");
            Regex testRegex = new Regex(@"[+-]?[0-9]*\.[0-9]*([eE][+-]?[0-9]+)?[dDfFMm]?");
            WriteLine(testRegex.Match("10.e-12f").Value);            
            ReadLine();
        }
    }
}
