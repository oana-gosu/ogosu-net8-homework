using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek4
{
    public class Crop
    {
        public Crop (string name)
        {
            this.name = name;
            
        }

        public string name;
        public string currentStage = "Seed";
        public List<string> stages = new List<string>() { "Seed", "Sprout", "Plant", "CanBeHarvested", "Harvested" };
       
        public void Water()
        {
            int i = stages.FindIndex(x => x == this.currentStage);
            if (i<stages.Count-2) 
            {
                this.currentStage = stages[i + 1];
            }
        }

        public void Harvest()
        {
            if (currentStage == "CanBeHarvested")
                {
                this.currentStage = "Harvested";
            }
        }

    }
}
