using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var pathLength = 0;
            var pathLength2 = 0;
            var weight = 0.0;
            var averageSpeed = 0.0;
            var id = "";
            var flag = false;
            var numberOfSoldiers = 0;
            //unos tenka
            do
            {
                Console.WriteLine("Unesite duljinu puta za tenk (u kilometrima):");
                flag = int.TryParse(Console.ReadLine(), out pathLength);
            } while (!flag);

            flag = false;

            Console.WriteLine("Unesite id za tenk:");
            id = Console.ReadLine();
            do
            {
                Console.WriteLine("Unesite težinu tenka:");
                flag = double.TryParse(Console.ReadLine(), out weight);
            } while (!flag);

            flag = false;
            do
            {
                Console.WriteLine("Unesite prosječnu brzinu za tenk(km/h):");
                flag = double.TryParse(Console.ReadLine(), out averageSpeed);
            } while (!flag);
            Tank tank=new Tank(id,weight,averageSpeed,pathLength);

            //unos brod
            flag = false;
            do
            {
                Console.WriteLine("Unesite duljinu puta za brod:");
                flag = int.TryParse(Console.ReadLine(), out pathLength);
            } while (!flag);
            flag = false;

            Console.WriteLine("Unesite id za brod:");
            id = Console.ReadLine();

            do
            {
                Console.WriteLine("Unesite težinu broda:");
                flag = double.TryParse(Console.ReadLine(), out weight);
            } while (!flag);
            flag = false;

            do
            {
                Console.WriteLine("Unesite prosječnu brzinu za brod:");
                flag = double.TryParse(Console.ReadLine(), out averageSpeed);
            } while (!flag);
            Warship warship=new Warship(id,weight,averageSpeed,pathLength);

            //unos amfibije
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

            Console.WriteLine("Unesite id za amfibiju:");
            id = Console.ReadLine();

            do
            {
                Console.WriteLine("Unesite težinu amfibije:");
                flag = double.TryParse(Console.ReadLine(), out weight);
            } while (!flag);
            flag = false;

            do
            {
                Console.WriteLine("Unesite prosječnu brzinu za amfibiju:");
                flag = double.TryParse(Console.ReadLine(), out averageSpeed);
            } while (!flag);
            Amfibia amfibia=new Amfibia(id,weight,averageSpeed,pathLength,pathLength2);

            flag = false;
            do
            {
                Console.WriteLine("Unesite broj vojnika koje treba prevesti:");
                flag = int.TryParse(Console.ReadLine(), out numberOfSoldiers);
            } while (!flag);

            NumberOfSoldiers.Number = numberOfSoldiers;
        }
    }
}
