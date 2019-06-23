using System;

namespace rageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double lostGamesCount = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double brokenHeadsets = Math.Floor(lostGamesCount / 2);
            double brokenMice = Math.Floor(lostGamesCount / 3);
            double brokenKeyboards = Math.Floor(lostGamesCount / 6);
            double brokendDisplays = Math.Floor(brokenKeyboards / 2);
            double totalExpenses =
                (brokenHeadsets * headsetPrice)
                + (brokenMice * mousePrice)
                + (brokenKeyboards * keyboardPrice)
                + (brokendDisplays * displayPrice);

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");

        }
    }
}
