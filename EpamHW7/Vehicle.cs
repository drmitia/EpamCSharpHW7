using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamHW7
{
    class Vehicle : Automobile
    {
        private int maxLoadWeight; //вантажопідйомність
        public int MaxLoadWeight
        { get; set; }
        public Vehicle (string vehicleName, int vehicleSpeed, int vehicleMaxLoadWeight) : base(vehicleName, vehicleSpeed)
        {
            MaxLoadWeight = vehicleMaxLoadWeight;
        }
        public override void ShowMoreInfo()
        {
            Console.WriteLine($"Автомобiль {Name} зi швидкiстю {MaxSpeed} та максимальною вагою {MaxLoadWeight}");
        }
    }
}
