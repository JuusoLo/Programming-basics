using System;

namespace Teht._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma muuttaa E-kirjaimet @-merkeiksi, syötä virke: ");
            string E = Console.ReadLine();           
            E = E.Replace('e','@');
            Console.WriteLine($"Loppullinen virkkeesi on: '{E}'");
            Console.ReadKey();
        }
    }
}
