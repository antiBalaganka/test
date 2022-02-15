using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class PassengerСar : Car
    {
        public PassengerСar(TC TC, int averageFuelConsumption, int tankCapacity, int speed, int numberOfPassengers, int maxPassengers) : base (TC, averageFuelConsumption, tankCapacity, speed)
        {
            NumberOfPassengers = numberOfPassengers;
            MaxPassengers = maxPassengers;
        }

        private int NumberOfPassengers { get; set; }
        private int MaxPassengers { get; set; }
        protected override void calculationTime(int distance)
        {
            if(MaxPassengers < NumberOfPassengers)
            {
                Console.WriteLine("Превышен лимит пассажиров");
                return;
            }
            int time = distance / Speed;
            Console.WriteLine($"{time}сек");
        }

        protected override void calculationDistance(int fuel)
        {
            if (MaxPassengers < NumberOfPassengers)
            {
                Console.WriteLine("Превышен лимит пассажиров");
                return;
            }
            int PowerReserve = 100 - NumberOfPassengers * 6;
            int distance = ((TankCapacity * fuel) / AverageFuelConsumption) * Speed ) *PowerReserve;
            Console.WriteLine(distance);
        }
    }
}
