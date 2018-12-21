using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OOP
{
    public class Tank:Vehicle
    {
        public Tank(string id, double weight, double averageSpeed)
        :base(id,weight,averageSpeed,30,6)
        {
            
        }

        public override string Print()
        {
            return base.Print() + $"Potrošeno gorivo";
        }
    }
}
