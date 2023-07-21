using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex4
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public abstract double CalculateBonus();
        public virtual string GetContactInfo()
        {
            
            return Name;
        }

        public enum Department
        {
            HR,
            IT,
            Sales,
            Marketing            
        }
    }
}
