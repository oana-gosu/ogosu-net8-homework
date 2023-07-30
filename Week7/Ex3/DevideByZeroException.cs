using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.Ex3
{
    public class DevideByZeroException : Exception
    {
        public DevideByZeroException(string message) : base(message) { }
    }
}
