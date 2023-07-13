using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek4
{
    public class Calculator
    {
        public int Add(int x, int y) { return x + y; }
        public int Subtract(int x, int y) { return x - y; }
        public int Multiply(int x, int y) { return x * y; }
        public int Divide(int x, int y) { return x / y; }
        public double Power(int x, int y) { return Math.Pow(x,y); }
        public double SquareRoot(int x) { return Math.Sqrt(x); }



    }
}
