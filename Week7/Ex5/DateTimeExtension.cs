﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.Ex5
{
    public static class DateTimeExtension
    {
        public static string ToFullDate(this DateTime date)
        {
            return date.ToString();
        }
    }
}
