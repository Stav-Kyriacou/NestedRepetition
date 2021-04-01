using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter < 5)
            {
                int counter2 = 0;

                while (counter2 < 5)
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
