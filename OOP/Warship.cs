﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Warship:Vehicle, ISwimmable, IFuelConsummable
    {
        public int PathLength { get; set; }
        public int FinalPath { get; set; }
        public Warship(string id, double weight, double averageSpeed,int pathLength)
            : base(id, weight, averageSpeed, 200, 50)
        {
            PathLength = pathLength;
        }
       
        public override string Print()
        {
            return base.Print() + $" | Potrošeno gorivo:{FuelConsumed()}";
        }
        public override int CalculatePath()
        {
            FinalPath = PathLength * (((int) Math.Ceiling((double)NumberOfSoldiers.Number / Capacity) - 1) * 2 + 1);
            return FinalPath;
        }

        public void Swim(int distance)
        {
            var distanceToAdd = 0;
            var time = (distance / AverageSpeed)*60;
            while (time >= 10)
            {
                if (random.Next(100) < 50)
                {
                    distanceToAdd += 3;
                    time += (3/AverageSpeed)*60;
                }

                time -= 10;
            }

            FinalPath = FinalPath + distanceToAdd;
        }

        public int FuelConsumed()
        {
            return FinalPath*FuelConsumption;
        }
    }
}
