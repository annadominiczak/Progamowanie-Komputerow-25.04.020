using System;

namespace zadanie_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj początek zakresu: ");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj koniec zakresu: ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());


            for (int a = lowerLimit; a <= upperLimit; a++)
            {
                for (int b = lowerLimit; b <= upperLimit; b++)
                {
                    for (int c = lowerLimit; c <= upperLimit; c++)
                    {
                        if (a * a + b * b == c * c && b > a && c > b)
                        {
                            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
                        }
                    }
                }
            }






        }
    }
}
