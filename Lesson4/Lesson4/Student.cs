using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
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
         

    }
}
