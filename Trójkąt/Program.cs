using System;
using System.Globalization;

namespace Trójkąt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            string _input_data = Console.ReadLine();

            _input_data = _input_data.Replace(";", "");


            string[] _data = _input_data.Split();


            double _a = Math.Round(double.Parse(_data[0]), 2);

            double _b = Math.Round(double.Parse(_data[1]), 2);

            double _c = Math.Round(double.Parse(_data[2]), 2);

           

            if (_a <= 0 || _b <= 0 || _c <= 0) Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");

            else if (!(_a <= _b + _c) || !(_b <= _a + _c) || !(_c <= _b + _a)) Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
            else
            {

                double _circuit = Math.Round(_a + _b + _c, 2);



                double _surface_area = Math.Round(Math.Sqrt((_a + _b + _c) * (_a + _b - _c) * (_a - _b + _c) * ((_a * -1) + _b + _c)) / 4, 2);

                Console.WriteLine("obwód = {0}", _circuit.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("pole = {0}", _surface_area.ToString("F", CultureInfo.InvariantCulture));





                double _x = Math.Max(_a, Math.Max(_b, _c));
                double _y = Math.Min(_a, Math.Min(_b, _c));
                double _z = _circuit - _x - _y;

                double _xx = _x * _x;
                double _yy = _y * _y;
                double _zz = _z * _z;


                double _yz = _yy + _zz;

                if (_xx == _yz)
                {
                    Console.WriteLine("trójkąt jest prostokątny");

                    if (_a == _b || _a == _c || _c == _b)
                    {
                        Console.WriteLine("trójkąt równoramienny");
                    }
                }
                else if (_xx < _yz)
                {
                    Console.WriteLine("trójkąt jest ostrokątny");

                    if (_a == _b && _a == _c && _c == _b)
                    {
                        Console.WriteLine("trójkąt równoboczny");
                    }

                    else if (_a == _b || _a == _c || _c == _b)
                    {
                        Console.WriteLine("trójkąt równoramienny");
                    }
                }
                else if (_xx > _yz)
                {
                    Console.WriteLine("trójkąt jest rozwartokątny");

                    if (_a == _b || _a == _c || _c == _b)
                    {
                        Console.WriteLine("trójkąt równoramienny");
                    }
                }


            }
        }
    }
}
