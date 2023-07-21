using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex6
{
    public class NewCircle: IShape, IColor
    {
        private double Radius { get; set; }
        public string Color 
        {
            get { return Color; } 
            set { Color = value; } 
        }
        public NewCircle(double radius, string color)
        {
            Radius = radius;
            Color = color;
            
        }
        double Pi = 3.14;
        double area;
        public double CalculateArea()
        {
            return area = Pi * Radius * Radius;
        }
        public string CalculateArea(string unit)
        {
            return "Area: " + area + unit;

        }


    }
}
