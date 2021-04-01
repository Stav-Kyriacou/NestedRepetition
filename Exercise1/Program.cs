using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            
            int counter = 0;

            while (counter < 5)
            {
                int counter2 = counter;

                while (counter2 < 10)
                {
                    Console.WriteLine(name);
                    counter2++;
                }

                Console.WriteLine();
                counter++;
            }
        }
    }
}