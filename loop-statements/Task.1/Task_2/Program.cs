using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9: ");

            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    if (i == 0)
                    {
                        Console.Write("{0}\t", i);
                    }
                    else
                    {
                        Console.Write("{0}\t", i * k);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
