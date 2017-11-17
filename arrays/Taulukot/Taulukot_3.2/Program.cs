using System;

namespace Taulukot_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjema arpoo yksiulotteiseen kokonaisluku talukkoon arvot väliltä 0-20");
            int[,] arrayNumber = new int[10,20];
            Random rnd = new Random();
            Console.WriteLine("[X,Y] = Arvo");

            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 20; y++)
                {
                    arrayNumber[i, y] = rnd.Next(0, 100);
                    if (arrayNumber[i, y] < 10)
                    {
                        Console.WriteLine($"[{i},{y}] = 0{arrayNumber[i, y]}");
                    }
                    else
                    {
                        Console.WriteLine($"[{i},{y}] = {arrayNumber[i, y]}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
