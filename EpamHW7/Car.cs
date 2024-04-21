using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamHW7
{
     class Car : Automobile
    {
        private int countOfSeats; //кількість місць
        public int CountOfSeats
        { get; set; }
        public Car (string carName, int carSpeed, int carCounOfSeats) : base(carName, carSpeed)
        {
            CountOfSeats = carCounOfSeats;
        }
        public override void ShowMoreInfo()
        {
            Console.WriteLine($"Автомобiль {Name} зi швидкiстю {MaxSpeed} та {CountOfSeats} мiсцями ");
        }
    }
}
