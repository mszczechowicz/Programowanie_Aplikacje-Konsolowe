using System;

namespace Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 2, 3, 4 };

            int[] b = new int[] { 0, 1, 1, 2, 3, 3, 3, 5, 5, 5 };

            Print(a, b);


        }
        public static void Print(int[] a, int[] b)
        {
            string liczby = "";


            for (int i = 0; i < a.Length; i++)
            {

                try
                {
                    if (a[i] == a[i + 1])
                    { continue; }

                }
                catch (IndexOutOfRangeException) { }


                for (int j = 0; j < b.Length; j++)
                {

                    if (a[i] == b[j])
                    {


                        break;
                    }

                    else if (a[i] != b[j])
                    {

                        if (b[j] == b[b.Length - 1])
                        {
                            if (a[i] != b[b.Length - 1])
                            {

                                liczby += a[i];

                                liczby += " ";
                            }

                            try
                            {
                                if (b[j] == b[j + 1])
                                {
                                    break;
                                }
                                else
                                {
                                    liczby += a[i];

                                    liczby += " ";
                                }
                            }
                            catch (IndexOutOfRangeException) { }

                        }


                    }

                }



            }



            if (liczby == "")
            {
                Console.WriteLine("empty");
            }
            else { Console.WriteLine(liczby); }
        }
    }
}
