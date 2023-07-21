using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Ex4
{
    public class Manager : Employee
    {
        private Department Department{get; set;}
        public Manager(string name, int age, double salary, Department department)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Department = department;
        }
        
        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }
        public override string GetContactInfo()
        {
            
            return "Name: " + Name + "Age: " + Age + "Department: " +Department + "Email: [email], Phone: [phone]";
        }


    }
}
