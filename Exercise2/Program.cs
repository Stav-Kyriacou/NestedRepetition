using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //User enters their name, it is written on the same line 10 times, which is repeated 10 times on different lines

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
