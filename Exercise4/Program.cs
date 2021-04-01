using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter < input)
            {
                int counter2 = counter;

                while (counter2 < input)
                {
                    Console.Write("x");
                    counter2++;
                }
                Console.WriteLine();
                counter++;
            }
        }
    }
}
