using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
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
