using System;

namespace loop_example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä luku. Ohjelma laskee parillisten ja parittomien summan: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int f = 1;
            int i = 0;
            int even = 0;
            int odd = 0;

            if (number < 0)
            {
                f = -1;
            }
            do
            {
                if (i % 2 == 0)
                    even += i;
                else
                    odd += i;

                i++;
            }
            while (i <= number * f);

            if (number < 0)
                even *= f;
            odd *= f;

            Console.WriteLine($"Parillisten lukujen summa = {even} ja parittomien lukujen summa = {odd}");

            Console.ReadKey();
        }
    }
}
