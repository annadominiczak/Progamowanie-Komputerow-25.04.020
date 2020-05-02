using System;

namespace Zadanie_12
{
    class Program
    {
        static void Main(string[] args)
        {

            int height, iteration, column, wynik = 0;
            Console.Write("Podaj wysokość: ");
            height = Convert.ToInt32(Console.ReadLine());

            for (iteration = 1; iteration <= height; iteration++)

            {
                for (column = 1; column <= iteration; column++)
                {

                    Console.Write(iteration * column);


                }

                Console.WriteLine("");

            }





            Console.ReadKey();



        }
    }
}
