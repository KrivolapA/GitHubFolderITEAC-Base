﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    interface ISchedulable
    {
        bool checkDate(DateTime date);
        int getHoursByDay(DateTime date);
    }
}
