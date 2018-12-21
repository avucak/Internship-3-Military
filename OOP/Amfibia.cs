using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Amfibia:Vehicle
    {
        public double PathLengthLand { get; set; }
        public double PathLengthSea { get; set; }
        public Amfibia(string id, double weight, double averageSpeed,double pathLengthLand, double pathLengthSea)
            : base(id, weight, averageSpeed, 70, 20)
        {
            PathLengthLand = pathLengthLand;
            PathLengthSea = pathLengthSea;
        }

        public override string Print()
        {
            return base.Print() + $"Potrošeno gorivo";
        }
    }
}
