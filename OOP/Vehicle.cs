using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OOP
{
     public abstract class Vehicle
    {
        public Random random = new Random();
        public string Id { get; set; }
        public double Weight { get; set; }
        public double AverageSpeed { get; set; }
        public double FuelConsumption { get; set; }
        public int Capacity { get; set; }

        public Vehicle(string id, double weight, double averageSpeed, double fuelConsumption, int capacity)
        {
            Id = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = fuelConsumption;
            Capacity = capacity;
        }
        public virtual string Print()
        {
            return
                $"Id: {Id} | Težina:{Weight} | Brzina:{AverageSpeed} | Potrošnja: {FuelConsumption} | Kapcitet: {Capacity}";
        }

        public virtual void CalculatePath()
        {

        }
    }
}
