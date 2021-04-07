using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1.2
            //A program receives a user's name and prints it for the amount of times that the user specifies.

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("How many times should I repeat it? ");
            int repeatAmount = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter < repeatAmount)
            {
                Console.WriteLine(name);
                counter++;
            }
        }
    }
}
