using System;

namespace Exercise5
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
                counter++;
                int counter2 = counter;

                while ((input - counter2) < input)
                {
                    Console.Write("x");
                    counter2--;
                }
                
                Console.WriteLine();
            }
        }
    }
}
