using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OOP
{
    public class Tank:Vehicle, IDriveable,IFuelConsummable
    {
        public int PathLength { get; set; }
        public int FinalPath { get; set; }
        public static int Number = 0;

        public Tank( int pathLength)
        :base("tank "+(Number+1).ToString(),60000,70,30,6)
        {
            Number++;
            PathLength = pathLength;
        }

        public override string Print()
        {
            return base.Print() + $" | Potrošeno gorivo:{FuelConsumed()}";
        }

        public override int CalculatePath(int numberOfSoldiers)
        {
            FinalPath = PathLength * (((int)Math.Ceiling((double)numberOfSoldiers / Capacity) - 1) * 2 + 1);
            return FinalPath;
        }

        public void Move(int distance)
        {
            var distanceToAdd = 0;
            while (distance >= 10)
            {
                if (random.Next(100) < 30)
                {
                    distanceToAdd += 5;
                    distance += 5;
                }

                distance -= 10;
            }

            FinalPath = FinalPath + distanceToAdd;
        }
        public double FuelConsumed()
        {
            return (double)(FinalPath * FuelConsumption/100);
        }
    }
}
