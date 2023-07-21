using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex3
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public abstract double CalculateArea();
        public virtual double GetPerimeter()
        { return Perimeter; }
        public virtual string GetPerimeter(string unit)
        { return Perimeter+ " " + unit; }
    }

   
}
