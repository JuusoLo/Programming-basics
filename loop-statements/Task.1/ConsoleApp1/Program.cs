using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa 1-10 kokonaisluvut sekä niiden neliöjuuret: ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} \t {Math.Sqrt(i):f2}");
            }

            Console.ReadKey();
        }
    }
}
