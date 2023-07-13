using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek4
{
    public class Farm
    {
        
        public Farm(string name, double area, int animalCount) 
        {
            this.name = name;
            this.area = area;
            this.animalCount = animalCount;

        }
        public string name;
        public double area;
        public int animalCount;
        public double density;

        public void AddAnimals()
        {
            Console.WriteLine("Input no of animals to be added:");
            int addedAnimals = Convert.ToInt32(Console.ReadLine());
            this.animalCount = this.animalCount + addedAnimals;
            
        }

        public double CalculateDensity()
        {
           double density = Convert.ToDouble(this.animalCount) / this.area;
            return density;
            
        }
    }
}

