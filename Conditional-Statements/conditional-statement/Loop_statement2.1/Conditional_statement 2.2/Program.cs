using System;

namespace Conditional_statement_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä sana tai lause!");
            string userInput = Console.ReadLine();
            string input = userInput.Replace(" ", "");

            for (int i = 0; i < input.Length; i++) 
            {
                Console.WriteLine($"{i + 1}.{userInput}");
            }
            Console.ReadKey();
        }
    }
}
