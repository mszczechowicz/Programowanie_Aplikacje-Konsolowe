using System;

namespace ile_do_emerytury
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Wprowadź dane: nazwisko wiek wiek_emerytalny");

            string _insert_data = Console.ReadLine();
            string[] _data = _insert_data.Split();

            string _nazwisko = _data[0];
            int _wiek = int.Parse(_data[1]);
            int _wiek_emerytalny = int.Parse(_data[2]);



            if ((_wiek | _wiek_emerytalny) < 0) Console.WriteLine("Wiek nie może być ujemny!");
            else if (_wiek < _wiek_emerytalny)
            {
                int _retirement_time = _wiek_emerytalny - _wiek;

                int _polish_ext = _retirement_time % 10;

                if ((_polish_ext == 2 || _polish_ext == 3 || _polish_ext == 4) && (_retirement_time != 12 && _retirement_time != 13 && _retirement_time != 14))
                {
                    Console.WriteLine("Witaj {0}! Do emerytury brakuje Ci {1} lata!", _nazwisko, _retirement_time);
                }
                else if (_polish_ext == 1) Console.WriteLine("Witaj {0}! Do emerytury brakuje Ci {1} rok!", _nazwisko, _retirement_time);
                else Console.WriteLine("Witaj {0}! Do emerytury brakuje Ci {1} lat!", _nazwisko, _retirement_time);

            }
            else Console.WriteLine("Witaj emerycie {0}!", _nazwisko);
        }
    }
}
