using System;

namespace zadanie_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfUnevenNumbers, currentUnevenNumber, currentIteration, sum = 0;
            Console.Write("Podaj liczbe: ");
            numberOfUnevenNumbers = Convert.ToInt32(Console.ReadLine());

            for (currentUnevenNumber = 1, currentIteration = 1;

                currentIteration <= numberOfUnevenNumbers;

                currentUnevenNumber += 2, currentIteration++)
            {

                sum += currentUnevenNumber;


            }

            Console.WriteLine("");
            Console.WriteLine("Suma wynosi: " + sum);

            Console.ReadKey();
        }
    }
}
