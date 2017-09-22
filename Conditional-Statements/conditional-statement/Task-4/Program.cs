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
            
           
                Console.Write("Syötä luku 1/3: ");
                // defain variables
                string userInput;

                userInput = Console.ReadLine();

                int numberX;
                int.TryParse(userInput, out numberX);

            Console.Write("Syötä luku 2/3: ");

            userInput = Console.ReadLine();

            int numberY;
            int.TryParse(userInput, out numberY);

            Console.Write("Syötä luku 2/3: ");

            userInput = Console.ReadLine();

            int numberZ;
            int.TryParse(userInput, out numberZ);

            // logic
            if (numberX < numberY)
            {
                if (numberX < numberZ)
                {
                    if (numberY < numberZ)
                    {
                        Console.WriteLine($"{numberX}, {numberY},{numberZ}");
                    }
                    else
                    {
                        Console.WriteLine($"{numberX}, {numberZ},{numberY}");
                    }
                }
                else
                {
                    Console.WriteLine($"{numberZ}, {numberX},{numberY}");
                }

            }
            else
            {
                if(numberX<numberZ)
            }

            // Check isNumber

            Console.ReadKey();
        }
    }
}
