using System;

namespace loop_example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee. Anna luku, jonka mistä summa lasketaan:");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            int sum = 0;
            while (i < number)
            {
                i = i + 1;
                sum = sum + i;
            }

            Console.WriteLine($"Lukujen summa: {sum}");
            Console.ReadKey();
        }
    }
}
