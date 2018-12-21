using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OOP
{
    public class Tank:Vehicle, IDriveable
    {
        public int PathLength { get; set; }
        public int FinalPath { get; set; }
        public Tank(string id, double weight, double averageSpeed,int pathLength)
        :base(id,weight,averageSpeed,30,6)
        {
            PathLength = pathLength;
        }

        public override string Print()
        {
            return base.Print() + $"Potrošeno gorivo";
        }

        public override void CalculatePath()
        {
            FinalPath = PathLength * ((NumberOfSoldiers.Number/Capacity-1)*2+1);
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
