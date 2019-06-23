using System;

namespace loginNoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            string currentPassword = Console.ReadLine();

            while (currentPassword != password)
            {

                Console.WriteLine("Incorrect password. Try again.");
                counter += 1;

                if (counter >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                
                currentPassword = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
