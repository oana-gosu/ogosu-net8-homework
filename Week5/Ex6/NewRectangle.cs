using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex6
{
    public class NewRectangle : IShape, IColor
    {
        private double Width {  get; set; }
        private double Height { get; set; }
        public NewRectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public string Color
        {
            get { return Color; }
            set { Color = value; }
        }
        public NewRectangle(double width, double height, string color)
        {
            Width = width;
            Height = height;
            Color = color;
        }
        double area;
        public double CalculateArea()
        {
            return area = Width * Height;
        }
        public string CalculateArea(string unit)
        {
            return "Area: " + area + unit;

        }
    }
}
