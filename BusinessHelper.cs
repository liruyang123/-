﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public static class BusinessHelper
    {
        public static Dictionary<int, int> dic = new Dictionary<int, int>();

        public static void InitData()
        {
            dic.Clear();
            dic.Add(1, 31);
            dic.Add(2, 28);
            dic.Add(3, 31);
            dic.Add(4, 30);
            dic.Add(5, 31);
            dic.Add(6, 30);
            dic.Add(7, 31);
            dic.Add(8, 31);
            dic.Add(9, 30);
            dic.Add(10, 31);
            dic.Add(11, 30);
            dic.Add(12, 31);
        }

        public static bool IsEndDay(int day, int month)
        {
            var data = dic[month];
            if (data == day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsFiveDay()
        {
            var week = DateTime.Now.DayOfWeek.ToString();
            if (week == "Friday")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}