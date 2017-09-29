using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Define instructions
            Console.WriteLine("Ohjelma lajittelee luvut nousevaan järjestykseen. Syötä kolme lukua.");
            {

                Console.Write("Syötä luku 1/3:");
                // defain variables
                string numero1 = Console.ReadLine();

                int numx = int.Parse(numero1);

                Console.Write("Syötä luku 2/3:");
                string numero2 = Console.ReadLine();

                int numy = int.Parse(numero2);

                Console.Write("Syötä luku 3/3:");
                string numero3 = Console.ReadLine();

                int numz = int.Parse(numero3);



                if (numx < numy && numx < numz)
                {
                    if (numy < numz)
                    {
                        Console.WriteLine($"Järjestys on {numx}, {numy}, {numz}.");
                    }
                    else
                    {
                        Console.WriteLine($"Järjestys on {numx}, {numz}, {numy}.");
                    }
                }
                if (numy < numx && numy < numz)
                {
                    if (numx < numz)
                    {
                        Console.WriteLine($"Järjestys on {numy}, {numx}, {numz}.");
                    }
                    else
                    {
                        Console.WriteLine($"Järjestys on {numy}, {numz}, {numx}.");
                    }
                }

                if (numz < numy && numz < numx)
                {
                    if (numx < numy)
                    {
                        Console.WriteLine($"Järjestys on {numz}, {numx}, {numy}.");
                    }
                    else
                    {
                        Console.WriteLine($"Järjestys on {numz}, {numy}, {numx}.");
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
