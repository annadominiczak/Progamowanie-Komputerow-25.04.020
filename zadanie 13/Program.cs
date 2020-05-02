using System;

namespace zadanie_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int height, row, column;
            Console.Write("Podaj liczbę naturalną n(n>4): ");
            height = Convert.ToInt32(Console.ReadLine());

            for (row = 1; row <= height; row++)
            {
                for (column = 1; column <= height; column++)
                {
                    if (row == height || column == height || height - row + 1 == column)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
