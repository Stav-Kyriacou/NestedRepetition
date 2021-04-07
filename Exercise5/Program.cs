using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //User enters a number, console outputs 'x' from 1 to the number entered on a new line sequentially
            //e.g output, user entered 5
            //      x
            //      xx
            //      xxx
            //      xxxx
            //      xxxxx


            Console.Write("How many lines? ");
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
