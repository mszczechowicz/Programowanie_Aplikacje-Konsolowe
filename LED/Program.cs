using System;

namespace LED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LED();
        }
        public static void LED()
        {
            string dane = Console.ReadLine();

            Console.WriteLine(dane);
            char[] dane_tablica = dane.ToCharArray();

            string pierwsza_linia = "";
            string druga_linia = "";
            string trzecia_linia = "";

            for (int i = 0; i < dane_tablica.Length; i++)
            {



                switch (dane_tablica[i])
                {
                    case '0':
                        pierwsza_linia += " _ ";
                        druga_linia += "| |";
                        trzecia_linia += "|_|";
                        break;
                    case '1':
                        pierwsza_linia += "   ";
                        druga_linia += "  |";
                        trzecia_linia += "  |";
                        break;
                    case '2':
                        pierwsza_linia += " _ ";
                        druga_linia += " _|";
                        trzecia_linia += "|_ ";
                        break;
                    case '3':
                        pierwsza_linia += " _ ";
                        druga_linia += " _|";
                        trzecia_linia += " _|";
                        break;
                    case '4':
                        pierwsza_linia += "   ";
                        druga_linia += "|_|";
                        trzecia_linia += "  |";
                        break;
                    case '5':
                        pierwsza_linia += " _ ";
                        druga_linia += "|_ ";
                        trzecia_linia += " _|";
                        break;
                    case '6':
                        pierwsza_linia += " _ ";
                        druga_linia += "|_ ";
                        trzecia_linia += "|_|";
                        break;
                    case '7':
                        pierwsza_linia += " _ ";
                        druga_linia += "  |";
                        trzecia_linia += "  |";
                        break;
                    case '8':
                        pierwsza_linia += " _ ";
                        druga_linia += "|_|";
                        trzecia_linia += "|_|";

                        break;
                    case '9':
                        pierwsza_linia += " _ ";
                        druga_linia += "|_|";
                        trzecia_linia += "  |";
                        break;

                    default:
                        Console.WriteLine("Wprowadzono nieprawidłowe znaki.");
                        break;
                }
            }
            Console.WriteLine(pierwsza_linia);
            Console.WriteLine(druga_linia);
            Console.WriteLine(trzecia_linia);
        }
    }
}
