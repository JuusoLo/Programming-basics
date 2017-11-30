using System;
using System.Collections.Generic;
using System.Linq;

namespace Teht._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee syöttämäsi virkkeesi vokaalien määrän.");
            Console.WriteLine("Syötä virke:  ");
            string userInput = Console.ReadLine().ToLower();
            int MP = userInput.Length;

            int count = 0;

            foreach(char ch in userInput)
            {
                if(ch =='a' || ch =='e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'y' || ch == 'ä' || ch == 'ö')
                {
                    count++;
                }
            }

            Console.WriteLine($"Virkkeesä: {userInput}, on vokaaleja: {count}" );

            Console.ReadKey();
        }
    }
}
