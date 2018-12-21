using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Amfibia:Vehicle, IDriveable
    {
        public int PathLengthLand { get; set; }
        public int PathLengthSea { get; set; }
        public int FinalPath { get; set; }

        public Amfibia(string id, double weight, double averageSpeed,int pathLengthLand, int pathLengthSea)
            : base(id, weight, averageSpeed, 70, 20)
        {
            PathLengthLand = pathLengthLand;
            PathLengthSea = pathLengthSea;
        }

        public override string Print()
        {
            return base.Print() + $"Potrošeno gorivo";
        }

        public override void CalculatePath()
        {
            FinalPath = (PathLengthLand+PathLengthSea) * ((NumberOfSoldiers.Number / Capacity - 1) * 2 + 1);
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
    }
}
