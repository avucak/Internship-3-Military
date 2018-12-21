using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Amfibia:Vehicle
    {
        public Amfibia(string id, double weight, double averageSpeed)
            : base(id, weight, averageSpeed, 70, 20)
        {

        }

        public override string Print()
        {
            return base.Print() + $"Potrošeno gorivo";
        }
    }
}
