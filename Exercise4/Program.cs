using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //User enters a number, console outputs 'x' from the number entered to 1 on a new line sequentially
            //e.g output, user entered 5
            //      xxxxx
            //      xxxx
            //      xxx
            //      xx
            //      x



            Console.Write("Enter starting number of x's: ");
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
