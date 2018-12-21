using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OOP
{
    public class Tank:Vehicle
    {
        public double PathLength { get; set; }
        public Tank(string id, double weight, double averageSpeed,double pathLength)
        :base(id,weight,averageSpeed,30,6)
        {
            PathLength = pathLength;
        }

        public override string Print()
        {
            return base.Print() + $"Potrošeno gorivo";
        }
    }
}
