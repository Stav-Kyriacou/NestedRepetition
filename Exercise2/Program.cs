using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1.1
            //A program receives a user's name and prints it 10 times on the same line. This process happens 10 times.

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            int counter = 0;

            while (counter < 10)
            {
                int counter2 = 0;

                while (counter2 < 10)
                {
                    Console.Write(name);
                    counter2++;
                }

                Console.WriteLine();
                counter++;
            }
        }
    }
}
