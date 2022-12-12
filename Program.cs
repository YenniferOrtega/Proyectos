using System;

namespace pruebaslogin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array bidimensional
            double[,] doble = new double[2, 2] { { 6, 3.2 }, { 6, 5.6 } };
            Console.WriteLine("rta {0}", doble[0,1]);

            // Array tridimensional
            double[,,] triple = new double[2, 2, 3] { { { 3.0, 6.9, 8.9 }, { 6.8, 5.6, 7.6 } }, { { 3.8, 4.3, 3.2 }, { 3.8, 10.6, 4.5 } } };
            Console.WriteLine("rta {0}", triple[0, 1, 2]);
            Console.ReadLine();
        



        }
    }
}
