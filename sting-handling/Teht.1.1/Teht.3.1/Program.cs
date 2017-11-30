using System;

namespace Teht._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tarkistaa onko viitenumero kotimainen.");
            Console.WriteLine("Syötä viitenumero: ");
            string userInput = Console.ReadLine();

            int[] mulip = { 1, 3, 7 };
            char[] refArray = userInput.ToCharArray();

            int sum = 0;
            int y = 0;

            for (int i = 0; i < refArray.Length; i++)
            {
                if(y>2)
                {
                    y = 0;
                }

                sum = sum + mulip[y] * refArray[i];
                y++;
            }

            //if (userInput.Length >= 4 && userInput.Length <= 20)
            //{
            //    Console.WriteLine($"Syöttämäsi viitenumero {userInput}, on kotimainen.");
            //}
            //else
            //{
            //    Console.WriteLine($"Syöttämäsi viitenumero {userInput}, ei ole kelvollinen.");
            //}



            Console.ReadKey();
            
        }
    }
}
