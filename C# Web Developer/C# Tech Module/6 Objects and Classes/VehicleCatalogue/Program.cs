using System;
using System.Linq;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split().ToList();
            List<Cars> cars = new List<Cars>();
            List<Trucks> trucks = new List<Trucks>();

            while (command[0] != "End")
            {
                if (command[0] == "car")
                {
                    Cars temp = new Cars();
                    temp.Model = command[1];
                    temp.Color = command[2];
                    temp.HP = int.Parse(command[3]);
                    cars.Add(temp);
                }
                else if (command[0] == "truck")
                {
                    Trucks temp = new Trucks();
                    temp.Model = command[1];
                    temp.Color = command[2];
                    temp.HP = int.Parse(command[3]);
                    trucks.Add(temp);
                }
                command = Console.ReadLine().Split().ToList();
            }

            string model = Console.ReadLine();

            while (model != "Close the Catalogue")
            {
                if (cars.Select(x => x.Model).Contains(model))
                {
                    int indexOfCar = cars.FindIndex(x => x.Model == model);

                    Console.WriteLine("Type: Car");
                    Console.WriteLine($"Model: {cars[indexOfCar].Model}");
                    Console.WriteLine($"Color: {cars[indexOfCar].Color}");
                    Console.WriteLine($"Horsepower: {cars[indexOfCar].HP}");
                }
                else if (trucks.Select(x => x.Model).Contains(model))
                {
                    int indexOftruck = trucks.FindIndex(x => x.Model == model);

                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {trucks[indexOftruck].Model}");
                    Console.WriteLine($"Color: {trucks[indexOftruck].Color}");
                    Console.WriteLine($"Horsepower: {trucks[indexOftruck].HP}");
                }
                model = Console.ReadLine();
            }

            double trucksAverage = 0;
            double carsAverage = 0;
            if (trucks.Count != 0)
            {
                trucksAverage = trucks.Average(x => x.HP);
            }
            if (cars.Count != 0)
            {
                carsAverage = cars.Average(x => x.HP);
            }          
            
            Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");
            


        }
    }
    class Cars
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }
    }
    class Trucks
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }

    }
}
