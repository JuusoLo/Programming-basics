using System;

namespace Taulukot_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjema määrittelee kolme kokonaislukutalukkoa arrT_1,arrT_2,arrT_3, joista jokaisessa on 10 kokonaislukua.");
            Random rnd = new Random();
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];
            Console.WriteLine("arrT_1,arrT_2,arrT_3 = Arvo");

            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = rnd.Next(51);
                arrT_2[i] = rnd.Next(51);

                if (arrT_1[i] > arrT_2[i])
                {
                    arrT_3[i] = arrT_1[i];
                }
                else
                {
                    arrT_3[i] = arrT_2[i];
                }
            }

            Console.Write("         ");
            for (int i = 1; i <= 10; i++)
            {
                if (i < 10)
                {
                    Console.Write($"0{i} ");
                }
                else
                {
                    Console.Write($"{i}\n");
                }
            }
            Console.Write("         ");
            for (int i = 0; i < 15; i++)

                //Taulukon viivat
            {
                Console.Write("--");
            }
            Console.Write("\n arrT_1: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{arrT_1[i]:00} ");
            }
            Console.Write("\n arrT_2: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{arrT_2[i]:00} ");
            }
            Console.Write("\n arrT_3: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{arrT_3[i]:00} ");
            }

            Console.ReadKey();

        }
    }
}
