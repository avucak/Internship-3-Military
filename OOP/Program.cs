using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathLength = 0;
            var pathLength2 = 0;
            var flag = false;
            var numberOfSoldiers = 0;
            do
            {
                Console.WriteLine("Unesite duljinu puta za tenk (u kilometrima):");
                flag = int.TryParse(Console.ReadLine(), out pathLength);
            } while (!flag);
            Tank tank=new Tank(pathLength);
            
            flag = false;
            do
            {
                Console.WriteLine("Unesite duljinu puta za brod:");
                flag = int.TryParse(Console.ReadLine(), out pathLength);
            } while (!flag);
            Warship warship=new Warship(pathLength);


            flag = false;
            do
            {
                do
                {
                    Console.WriteLine("Unesite duljinu kopnenog puta za amfibiju:");
                    flag = int.TryParse(Console.ReadLine(), out pathLength);
                } while (!flag);

                flag = false;
                do
                {
                    Console.WriteLine("Unesite duljinu morskog puta za amfibiju:");
                    flag = int.TryParse(Console.ReadLine(), out pathLength2);
                } while (!flag);
                if (pathLength + pathLength2 > warship.PathLength || pathLength + pathLength2 > tank.PathLength)
                {
                    Console.WriteLine("Amfibija treba imati najkraći put, ponovite unos");
                    flag = false;
                }
            } while (!flag);
            Amfibia amfibia=new Amfibia(pathLength,pathLength2);

            flag = false;
            do
            {
                Console.WriteLine("Unesite broj vojnika koje treba prevesti:");
                flag = int.TryParse(Console.ReadLine(), out numberOfSoldiers);
            } while (!flag);
            
            tank.Move(tank.CalculatePath(numberOfSoldiers));
            warship.Swim(warship.CalculatePath(numberOfSoldiers));
            amfibia.Move(amfibia.CalculatePath(numberOfSoldiers));
            amfibia.Swim(amfibia.CalculatePathSea(numberOfSoldiers));
            Console.WriteLine("Podaci za tenk: "+tank.Print());
            Console.WriteLine("Podaci za brod: " + warship.Print());
            Console.WriteLine("Podaci za amfibiju: " + amfibia.Print());
            var vehiclesAndFuelConsumed=new Dictionary<string,double>()
                {{"tenk",tank.FuelConsumed()},
                 { "brod",warship.FuelConsumed()},
                 { "amfibija",amfibia.FuelConsumed()}
                };
            var minimum= vehiclesAndFuelConsumed.Values.Min();
            Console.WriteLine("Koje se vozilo treba odabrati, jer je potrošilo najmanje goriva: ");
            foreach (var pair in vehiclesAndFuelConsumed)
            {
             if(pair.Value==minimum)
                      Console.WriteLine(pair.Key);               
            }
            
        }
    }
}
