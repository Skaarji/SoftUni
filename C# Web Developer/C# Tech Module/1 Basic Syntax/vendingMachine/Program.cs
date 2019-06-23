using System;

namespace vendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalCoins = 0.00;

            while (input != "Start")
            {
                double coins = double.Parse(input);

                if (coins != 0.1 &&
                     coins != 0.2 &&
                     coins != 0.5 &&
                     coins != 1 &&
                     coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    input = Console.ReadLine();
                }
                else
                {
                    totalCoins += coins;
                    input = Console.ReadLine();
                }

            }
            input = Console.ReadLine();
            while (input != "End")
            {
                double productPrice = 0;

                switch (input)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (totalCoins >= productPrice && productPrice > 0)
                {
                    string productToLower = input.ToLower();
                    Console.WriteLine($"Purchased {productToLower}");
                    totalCoins -= productPrice;
                }
                else if (totalCoins < productPrice && productPrice > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalCoins:f2}");
        }
    }
}
