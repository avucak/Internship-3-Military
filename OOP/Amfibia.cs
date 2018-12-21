using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Amfibia:Vehicle, IDriveable,ISwimmable,IFuelConsummable
    {
        public int PathLengthLand { get; set; }
        public int PathLengthSea { get; set; }
        public int FinalPathLand { get; set; }
        public int FinalPathSea { get; set; }

        public Amfibia(string id, double weight, double averageSpeed,int pathLengthLand, int pathLengthSea)
            : base(id, weight, averageSpeed, 70, 20)
        {
            PathLengthLand = pathLengthLand;
            PathLengthSea = pathLengthSea;
        }

        public override string Print()
        {
            return base.Print() + $" | Potrošeno gorivo:{FuelConsumed()}";
        }

        public override int CalculatePath()
        {
            FinalPathLand = PathLengthLand * (((int)Math.Ceiling((double)NumberOfSoldiers.Number / Capacity) - 1) * 2 + 1);
            return FinalPathLand;
        }

        public int CalculatePathSea()
        {
            FinalPathSea = PathLengthSea * (((int)Math.Ceiling((double)NumberOfSoldiers.Number / Capacity) - 1) * 2 + 1);
            return FinalPathSea;
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

            FinalPathLand = FinalPathLand + distanceToAdd;
        }
        public void Swim(int distance)
        {
            var distanceToAdd = 0;
            var time = (distance / AverageSpeed) * 60;
            while (time >= 10)
            {
                if (random.Next(100) < 50)
                {
                    distanceToAdd += 3;
                    time += (3 / AverageSpeed) * 60;
                }

                time -= 10;
            }

            FinalPathSea = FinalPathSea + distanceToAdd;
        }
        public int FuelConsumed()
        {
            return (FinalPathLand+FinalPathSea) * FuelConsumption;
        }
    }
}
