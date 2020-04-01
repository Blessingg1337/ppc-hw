using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Napište číslo.");
                pole[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(pole[i] + " ");

                if (pole[i] > 0)
                {
                    pole[i] = 1;
                }
                if (pole[i] < 0)
                {
                    pole[i] = -1;
                }
            }
            Console.Write(" - Zadané čísla");
            Console.WriteLine();

            Console.Write(pole[0] + " ");
            Console.Write(pole[1] + " ");
            Console.Write(pole[2] + " ");
            Console.Write(pole[3] + " ");
            Console.Write(pole[4] + " ");
            Console.Write(pole[5] + " ");
            Console.Write(pole[6] + " ");
            Console.Write(pole[7] + " ");
            Console.Write(pole[8] + " ");
            Console.Write(pole[9] + " ");
            Console.Write(" - Přeformátované čísla");
            Console.ReadKey();
        }
    }
}
