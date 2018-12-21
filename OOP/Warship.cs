using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Warship:Vehicle
    {
        public double PathLength { get; set; }
        public Warship(string id, double weight, double averageSpeed,double pathLength)
            : base(id, weight, averageSpeed, 200, 50)
        {
            PathLength = pathLength;
        }
       
        public override string Print()
        {
            return base.Print() + $"Potrošeno gorivo";
        }
    }
}
