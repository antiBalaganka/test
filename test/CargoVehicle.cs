using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class CargoVehicle : Car
    {
        public CargoVehicle(TC TC, int averageFuelConsumption, int tankCapacity, int speed, int loadCapacity, int cargoWeight) : base(TC, averageFuelConsumption, tankCapacity, speed)
        {
            LoadCapacity = loadCapacity;
            CargoWeight = cargoWeight;
        }

        private int LoadCapacity { get; set; }
        private int CargoWeight { get; set; }
        protected override void calculationTime(int distance)
        {
            if (LoadCapacity < CargoWeight)
            {
                Console.WriteLine("Перегруз");
                return;
            }
            int time = distance / Speed;
            Console.WriteLine($"{time}сек");
        }

        protected override void calculationDistance(int fuel)
        {
            if (LoadCapacity < CargoWeight)
            {
                Console.WriteLine("Перегруз");
                return;
            }
            int PowerReserve = 100 - CargoWeight / 200 * 4;
            int distance = (((TankCapacity * fuel) / AverageFuelConsumption) * Speed ) * PowerReserve;
            Console.WriteLine(distance);
        }
    }
}
