using System;

namespace padwanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());
            double numberOfStudents = double.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            double numberOfSabers = Math.Ceiling(numberOfStudents * 1.10);
            double freeBelts = Math.Floor(numberOfStudents / 6);

            double totalPrice = (numberOfSabers * priceLightsaber)
                + (numberOfStudents * priceRobe)
                + (priceBelt * (numberOfStudents - freeBelts));

            if (totalPrice > availableMoney)
            {
                double moneyNeeded = Math.Abs(availableMoney - totalPrice);
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }
            else if ( totalPrice <= availableMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }

        }
    }
}
