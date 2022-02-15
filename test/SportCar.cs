using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class SportCar : Car
    {
        public SportCar(TC TC, int averageFuelConsumption, int tankCapacity, int speed) : base(TC, averageFuelConsumption, tankCapacity, speed)
        {

        }

        protected override void calculationTime(int distance)
        {
            int time = distance / Speed;
            Console.WriteLine($"{time}сек");
        }

        protected override void calculationDistance(int fuel)
        {
            int distance = ((TankCapacity * fuel) / AverageFuelConsumption) * Speed;
            Console.WriteLine(distance);
        }
    }
}
