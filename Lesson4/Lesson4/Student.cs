using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class StudentPointComparator : IComparer<Student>
    {
        public int Compare(Student st1, Student st2)
        {
            return 0;
        }
    }
    class Student
    {
        int age;
        string name;
        string surname;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value>18 && value < 100)
                    age = value;
            }
        }
        public static Student createStudent()
        {
            return new Student();
        }
        public Student()
        {

        }
        public string FullName(string title) => title + " " + name + " " + surname;


        public string FullName2(string title)
        {
            return title + " " + name + " " + surname;
        }


    }
}
