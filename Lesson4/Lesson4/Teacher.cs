using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Teacher
    {
        ISchedulable[] tasks;
        public bool checkSchedule(DateTime day)
        {
            bool result = false;
            for (int i = 0; i < tasks.Length; i++)
                for (int j = i + 1; j < tasks.Length; j++)
                    if (tasks[i].getHoursByDay(day) == tasks[j].getHoursByDay(day))
                        result = true;
            return result;
        }
        public void schedule(ISchedulable task)
        {

        }
    }
}
