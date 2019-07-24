using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                Tire[] tireSet = new Tire[4];

                for (int j = 0; j < 4; j++)
                {
                    Tire tire = new Tire(double.Parse(input[5]), int.Parse(input[6]));
                    tireSet[j] = tire;
                }

                Car currentCar = new Car(input[0]
                    , new Engine(int.Parse(input[1]), int.Parse(input[2]))
                    , new Cargo(int.Parse(input[3]), input[4])
                    , tireSet);

                cars.Add(currentCar);

            }
            string command = Console.ReadLine();

            //Console.WriteLine(string.Join(Environment.NewLine, cars
            // .Where(c => c.Cargo.CargoType == command && command == "fragile"
            //     ? c.TireSet
            //         .Where(t => t.TirePressure < 1)
            //         .FirstOrDefault() != null
            //     : c.Engine.EnginePower > 250)
            // .Select(c => c.Model)));

            if (command == "fragile")
            {
                Console.WriteLine(string.Join(Environment.NewLine,
                     cars
                    .Where(x => x.Cargo.CargoType == "fragile")
                    .Where(x => x.TireSet.Where(t => t.TirePressure < 1).FirstOrDefault() != null)
                    .Select(x => x.Model)));

            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine,
                      cars
                     .Where(x => x.Cargo.CargoType == "flamable")
                     .Where(x => x.Engine.EnginePower > 250)
                     .Select(x => x.Model)));


            }
        }
    }
}
