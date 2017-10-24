using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace Lesson4
{
    [Flags]
    public enum DaysOfWeek : byte
    {
        Monday=2,
        Tuesday=4,
        Wednesday=8,
        Thirsday=16,
        Friday=32,
        Saturday=64,
        Sunday=128
    }
    public enum Averageoptions
    {
        none,
        countZeroes,
        onlyTopFive
    }
    class IntWrapper
    {
        public int value;
    }
    class Program
    {
        static int val;
        static int Method(out int x)
        {
            x = 10;
            x++;
            WriteLine("In Method x = {0}", x);
            return x;
        }
        static int Method(int x)
        {
            x = 10;
            x++;
            WriteLine("In Method x = {0}", x);
            return x;
        }
        static int Method(int x,int z, int y =20)
        {
            x = 10;
            x++;
            WriteLine("In Method y = {0}", y);
            return x;
        }
        
        static float Method(IntWrapper x)
        {
            x.value++;
            WriteLine("In Method x value = {0}", x.value);            
            return x.value;
        }
        
        static void TestMethod(int x, int y=7, int z=6)
        {
            WriteLine("x = {0}",x);
            WriteLine("y = {0}",y);
            WriteLine("z = {0}",z);
        }
        static void multipleArgsMethod(string text, params int[] values)
        {
            foreach (int i in values)
                WriteLine(text + "{0}", i);
        }
        static void EnumerationMethod()
        {
            DaysOfWeek courseSchedule = DaysOfWeek.Monday | DaysOfWeek.Wednesday | DaysOfWeek.Friday;
            DaysOfWeek requestedSchedule = DaysOfWeek.Monday | DaysOfWeek.Wednesday;
            DaysOfWeek secretSchedule = (DaysOfWeek)255;
            Console.WriteLine(secretSchedule);
            if ((requestedSchedule & courseSchedule) == requestedSchedule)
                Console.WriteLine("Course is good");
            //int? x = null;
            //int y = x ?? 10;
            Course[] allCourses = new Course[10];
            int numCourses = 0;
            Student goodStudent = Student.createStudent();
            Student badStudent = new Student { Age = 20 };
            badStudent.Age = 10;
            if (badStudent != null)
            {
                goodStudent.Age = badStudent?.Age ?? 10;
            }
            StudentStruct stStruct;
            stStruct.Age = 13;
            allCourses[numCourses++] = new Course("first");
            Regex testRegex = new Regex(@"[+-]?[0-9]*\.[0-9]*([eE][+-]?[0-9]+)?[dDfFMm]?");
            WriteLine(testRegex.Match("10.e-12f").Value);
            int x = 10;
            Method(x, 1);
            WriteLine("In Main x = {0}", x);
            IntWrapper xw = new IntWrapper { value = 10 };
            Method(x: xw);
            TestMethod(10, 11);
            WriteLine("In Main x value = {0}", xw.value);
            multipleArgsMethod("Our values", 123, 4, 2, 72, 3);
            ReadLine();
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[25];
            for(int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }
            Course baseCourse = null;
            try {
                baseCourse = new Course("new course");
                foreach(Student st in students)
                {
                    baseCourse.AddStudent(st);
                }
            }
            catch(CoursesException e)
            {

                WriteLine("Added up to {0} students", e.currentNumberOfStudents);                
                //baseCourse.StudentsAtCourse = e.currentNumberOfStudents;
            }
            WriteLine(baseCourse["  "]);            
            ReadLine();
        }
    }
}
