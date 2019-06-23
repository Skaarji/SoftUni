using System;
using System.Collections.Generic;
using System.Linq;

namespace vaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> inputSplit = input.Split(", ").ToList();
            Dictionary<string, double> gameAndPrice = new Dictionary<string, double>();
            Dictionary<string, List<string>> gameAndDLC = new Dictionary<string, List<string>>();

            for (int i = 0; i < inputSplit.Count; i++)
            {
                List<string> tokenSplit = inputSplit[i].Split('-').ToList();
                if (tokenSplit.Count == 2)
                {
                    string game = tokenSplit[0];
                    double price = double.Parse(tokenSplit[1]);
                    if (!gameAndPrice.ContainsKey(game))
                    {
                        gameAndPrice.Add(game, price);
                        gameAndDLC.Add(game, new List<string>());
                    }
                }
                else if (tokenSplit.Count==1)
                {
                    tokenSplit = inputSplit[i].Split(':').ToList();
                    string game = tokenSplit[0];
                    string dlc = tokenSplit[1];
                    if (gameAndPrice.ContainsKey(game))
                    {
                        gameAndDLC[game].Add(dlc);
                        gameAndPrice[game] *= 1.2;
                    }
                }
            }
            foreach (var game in gameAndDLC)
            {
                if (game.Value.Count == 0)
                {
                    gameAndPrice[game.Key] *= 0.8;
                }
                else if (game.Value.Count >0)
                {
                    gameAndPrice[game.Key] *= 0.5;
                }
            }
            foreach (var game in gameAndPrice.OrderBy(x => x.Value))
            {
                if (gameAndDLC[game.Key].Count>0)
                {
                    Console.WriteLine($"{game.Key} - {gameAndDLC[game.Key][0]} - {game.Value:f2}");
                }
            }
            foreach (var game in gameAndPrice.OrderByDescending(x => x.Value))
            {
                if (gameAndDLC[game.Key].Count == 0)
                {
                    Console.WriteLine($"{game.Key} - {game.Value:f2}");
                }
                
            }
            
        }
    }
}