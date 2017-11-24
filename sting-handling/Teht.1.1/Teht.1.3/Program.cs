using System;

namespace Teht._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä virke, ohjelma laskee M-kirjaimien määrän:");
            string UserInput = Console.ReadLine().ToUpper();

            int i = 0;
            foreach(char x in UserInput)
            {
                if (x == 'M')
                    i++;
            }
            Console.WriteLine($"Tekstissä on {i} M-kirjainta! ");
            Console.ReadKey();
        }
    }
}
