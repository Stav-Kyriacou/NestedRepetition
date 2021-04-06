using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = i; j < 11; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
