using System;

namespace Conditional_statement_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int summa = 0;
            int userInput = 0;
            bool isNumber = true;
            Console.WriteLine("Syötä luku. -1 lopettaa ohjelman ja tulostaa summan");

            while (isNumber)
            {
                Console.Write("Luku: ");
                isNumber = int.TryParse(Console.ReadLine(), out userInput);

                if (userInput == -1)
                {
                    break;
                }
                else
                {
                    summa += userInput;
                }
            }
            Console.WriteLine($"Lukujen summa on: {summa}");
            Console.ReadKey();
        }
    }
}
