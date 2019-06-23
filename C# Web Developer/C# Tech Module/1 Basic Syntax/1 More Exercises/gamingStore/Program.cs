using System;

namespace gamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double startingMoney = balance;            
            double priceRoverWatch = 29.99;
            double priceHonored2 = 59.99;
            double priceZplinterZell = 19.99;
            double priceCSOG = 15.99;
            double priceOutFall4 = 39.99;
            double priceRoverWatchOriginsEdition = 39.99;
            string input = Console.ReadLine();

            while (input != "Game Time")
            {
                switch (input)
                {
                    case "RoverWatch":
                        if (balance < priceRoverWatch)
                        {
                            Console.WriteLine("Too Expensive" );
                            input = Console.ReadLine();
                            continue;
                        }
                        balance -= priceRoverWatch;
                        Console.WriteLine($"Bought {input}");
                        break;
                    case "Honored 2":
                        if (balance < priceHonored2)
                        {
                            Console.WriteLine("Too Expensive");
                            input = Console.ReadLine();
                            continue;
                        }
                        balance -= priceHonored2;
                        Console.WriteLine($"Bought {input}");
                        break;
                    case "Zplinter Zell":
                        if (balance < priceZplinterZell)
                        {
                            Console.WriteLine("Too Expensive");
                            input = Console.ReadLine();
                            continue;
                        }
                        balance -= priceZplinterZell;
                        Console.WriteLine($"Bought {input}");
                        break;
                    case "CS: OG":
                        if (balance < priceCSOG)
                        {
                            Console.WriteLine("Too Expensive");
                            input = Console.ReadLine();
                            continue;
                        }
                        balance -= priceCSOG;
                        Console.WriteLine($"Bought {input}");
                        break;
                    case "OutFall 4":
                        if (balance < priceOutFall4)
                        {
                            Console.WriteLine("Too Expensive");
                            input = Console.ReadLine();
                            continue;
                        }
                        balance -= priceOutFall4;
                        Console.WriteLine($"Bought {input}");
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance < priceRoverWatchOriginsEdition)
                        {
                            Console.WriteLine("Too Expensive");
                            input = Console.ReadLine();
                            continue;
                        }
                        balance -= priceRoverWatchOriginsEdition;
                        Console.WriteLine($"Bought {input}");
                        break;
                    default:
                        Console.WriteLine("Not Found" );
                        break;
                }
                if (balance == 0.00)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${(startingMoney - balance):f2}. Remaining: ${balance:f2}");

        }
    }
}
