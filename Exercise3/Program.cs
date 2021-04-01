using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for the users name and how many times it should be repeated, outputs the users name on a new line as many times as was entered by the user

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
