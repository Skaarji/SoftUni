using System;
using System.Collections.Generic;

namespace ExCrossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int counter = 0;
            bool IsCrash = false;

            string command = Console.ReadLine();
            while (command != "END")
            {
                if (command =="green" && cars.Count > 0)
                {
                    if (IsCrash ==true)
                    {
                        break;
                    }
                   int  greenLightLeft = greenLight;
                    while (greenLightLeft > 0 && IsCrash == false && cars.Count >0)
                    {
                        string currentCar = cars.Peek();
                        int currentCarLenght = currentCar.Length;

                        if (currentCarLenght <= greenLightLeft)
                        {
                            greenLightLeft -= currentCarLenght;
                            cars.Dequeue();
                            counter++;
                            continue;
                        }
                        else if (currentCarLenght > greenLightLeft)
                        {
                            
                            if (currentCarLenght > greenLightLeft+freeWindow)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {currentCar[greenLightLeft + freeWindow]}.");
                                IsCrash = true;
                                break;
                            }
                            else if (currentCarLenght <= greenLightLeft+freeWindow)
                            {
                                cars.Dequeue();
                                counter++;
                                break;
                            }
                        }
                    }
                }
                else if (command != "green")
                {
                    cars.Enqueue(command);                    
                }
                command = Console.ReadLine();
            }
            if (IsCrash == false)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{counter} total cars passed the crossroads.");
            }
        }
    }
}
