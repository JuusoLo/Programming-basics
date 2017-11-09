using System;

namespace Loop_statement2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä sana tai lause!");
            string userInput = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. {userInput}");
            }
            Console.ReadKey();

        }
    }
}
