using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Pyramid Drawing");
            Console.Write("How many lines should it be? ");

            int rows = int.Parse(Console.ReadLine());               //ask user how many rows to draw
            int stars = (rows * 2) - 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j >= 1; j--)                        //draws the spaces
                {
                    Console.Write(" ");
                }           

                for (int k = 0; k < stars; k++)                     //draws the x's
                {
                    Console.Write("x");

                }

                Console.WriteLine();

                stars -= 2;
            }
        }
    }
}
