using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex3
{
    public class Rectangle : Shape
    {
        public Rectangle(string color, double width, double height)
        {
            Width = width;
            Height = height;
            Color = color;
        }
        private double Width { get; set; }
        private double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Height + Width);
        }

        public override string GetPerimeter(string unit)
        {
            return "Perimeter:" + (2 * (Height + Width)) + " " + unit;
        }
    }
}
