using System;

namespace Wzorek_ASCI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wzorek(5);
        }


        public static void Wzorek(int n)
        {
            if (n % 2 == 0)
            { n--; }
            if (n < 3) { Console.WriteLine("Nie uda się zbudować piramidy"); }

            int x = 0;

            for (int i = 1; i < n;)
            {
                if (x == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    n = n - 2;
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();

                x++;
            }



        }
    }
}
