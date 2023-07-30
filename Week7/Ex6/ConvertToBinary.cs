using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.Ex6
{
    public static class ConvertToBinary
    {
        public static string ToBinary(this int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
