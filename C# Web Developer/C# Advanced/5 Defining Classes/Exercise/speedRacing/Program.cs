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
                string[] carInput = Console.ReadLine().Split().ToArray();
                Car currentCar = new Car(carInput[0], double.Parse(carInput[1]), double.Parse(carInput[2]));
                bool contains = true;
                foreach (var car in cars)
                {
                    if (car.Model == currentCar.Model)
                    {
                        contains = false;
                        break;
                    }
                    contains = true;
                }
                if (contains==true)
                {
                    cars.Add(currentCar);
                }

            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split().ToArray();
                string model = command[1];
                double km = double.Parse(command[2]);
                foreach (var car in cars)
                {
                    if(car.Model==model)
                    {
                        car.Drive(km);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}