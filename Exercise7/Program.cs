using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pyramid Drawing");
            Console.Write("How many lines should it be? ");

            int rows = int.Parse(Console.ReadLine());               //ask user how many rows to draw
            int stars = 1;
            int spaces = rows - 1;

            for (int i = 0; i < rows; i++)
            {

                for (int j = i; j < spaces; j++)                    //draws the spaces
                {
                    Console.Write(" ");
                }           

                for (int k = 0; k < stars; k++)                     //draws the x's
                {
                    Console.Write("x");

                }

                Console.WriteLine();

                stars += 2;
            }
        }
    }
}
