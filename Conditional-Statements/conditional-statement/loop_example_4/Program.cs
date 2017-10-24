using System;

namespace loop_example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //int.TryParse(userInput, out int number);
            bool isNumber;
            int N;
            int sum = 0;

            Console.WriteLine("Ohjelma laskee. Anna luku, mistä summa lasketaan, myö negatiivisilla luvuilla.:");
            Console.WriteLine("Syötä luku");

            if (isNumber = int.TryParse(Console.ReadLine(), out N))
            {
                if (N > 0)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        sum = sum + i;
                    }
                }
                else if (N < 0)
                {
                    for (int i = 0; i >= N; i--)
                    {
                        sum = sum + i;
                    }
                }

                Console.WriteLine($"Lukujen summa on: {sum}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Syötit muuta kuin numeron");
                Console.ReadKey();
            }
        }
    }
}
