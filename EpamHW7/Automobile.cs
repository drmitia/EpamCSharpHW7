using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamHW7
{
    class Automobile
    {
        private string name;
        private int maxSpeed;
        
        public string Name  
        { get; set; }
        public int MaxSpeed
        { get; set; }
        public Automobile (string automobileName, int automobileSpeed) 
        {
            Name = automobileName;
            MaxSpeed = automobileSpeed;
        }
        public virtual void ShowMoreInfo()
        {
            Console.WriteLine($"Автомобiль {Name} зi швидкiстю {MaxSpeed}");
        }

        
        public Automobile CompareSpeed(Automobile otherAutomobile) 
        {
            if (this.MaxSpeed > otherAutomobile.MaxSpeed)
            {
                return this;
            }
            else if (this.MaxSpeed < otherAutomobile.MaxSpeed)
            {
                return otherAutomobile;
            }
            else 
            { 
                return otherAutomobile; 
            }
        }
    }
}
