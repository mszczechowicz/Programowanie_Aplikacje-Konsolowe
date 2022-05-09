using System;

namespace Zgadywanie_liczby

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Komputer wylosował dla Ciebie liczbę z zakresu od 1 do 10. Spróbuj odgadnąć jaka to liczba.");

            Random rnd = new Random();
            int _los = rnd.Next(1, 11);

            int _choice;
            int _count = 0;

            do
            {
                Console.Write("Podaj swoją liczbę: ");
                _choice = int.Parse(Console.ReadLine());
                if (_choice > 10 || _choice < 1)
                {
                    Console.WriteLine("Podałeś liczbę z poza  zakresu.");
                }
                else
                {
                    _count++;
                    Console.WriteLine("Próba : {0}", _count);

                    if (_los < _choice)
                    {
                        Console.WriteLine("Za dużo.");
                    }
                    else if (_los > _choice)
                    {
                        Console.WriteLine("Za mało.");
                    }
                    else
                    {
                        Console.WriteLine("Podałeś wylosowaną wartość komputera :[{0}] Gratulacje, wygrałeś...", _los);
                    }
                }

            } while (_los != _choice);
        }
    }
}
