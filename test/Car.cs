using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    abstract class Car
    {
        protected Car(TC TC, int averageFuelConsumption, int tankCapacity, int speed)
        {
            tc = TC;
            AverageFuelConsumption = averageFuelConsumption;
            TankCapacity = tankCapacity;
            Speed = speed;
        }
        protected TC tc { get; set; }
        protected int AverageFuelConsumption { get; set; }
        protected int TankCapacity { get; set; }
        protected int Speed { get; set; }

        protected abstract void calculationTime(int distance);
        protected abstract void calculationDistance(int fuel);
    }
}
