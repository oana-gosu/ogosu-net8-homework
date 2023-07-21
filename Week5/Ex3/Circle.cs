using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex3
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public double Pi { get; set; }
        public Circle(string color, double radius) 
        { 
            Color = color;
            Radius = radius;
            Pi = 3.14;
        }
        public override double CalculateArea()
        {
           return Pi*Radius*Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Pi * Radius;
        }
        public override string GetPerimeter(string unit)
        {
            return "Circumference:" + 2 * Pi * Radius + " " + unit;
        }
    }
}
