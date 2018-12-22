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
        public double Weight { get; }
        public double AverageSpeed { get; }
        public int FuelConsumption { get; }
        public int Capacity { get; }

        public Vehicle(string id, double weight, double averageSpeed, int fuelConsumption, int capacity)
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

        public virtual int CalculatePath(int number)
        {
            return 0;
        }

        public virtual double FuelConsumed()
        {
            return 0;
        }
    }
}
