using System;

namespace Teht._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma ilmoittaa syöttämän virkkeesi merkkien määrän, syötä virke:");
            string merkkijono = Console.ReadLine();
            int length = merkkijono.Length;
            Console.WriteLine($"Syötteesä on {length} merkkiä");
            Console.ReadKey();
        }        
    }
}
