using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i, j;
            Console.Write("Podaj ilość liczb: ");
            number = Convert.ToInt32(Console.ReadLine());


            for (i = 1; i <= number; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    j = i * 7;
                    Console.WriteLine(j);
                }


            }
            Console.ReadKey();
        }

    }
}
