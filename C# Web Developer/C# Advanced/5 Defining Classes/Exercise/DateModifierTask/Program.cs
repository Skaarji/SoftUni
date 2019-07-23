using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();

            DateModifier dif = new DateModifier();
            int result = dif.difference(dateOne, dateTwo);

            Console.WriteLine(result);


        }
    }
}
