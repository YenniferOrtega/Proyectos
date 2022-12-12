using System;

namespace pruebaslogin
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 9;
            int v1 = 4;
            double v2 = 11;
            double v3 = 11;
            string name;
            var data = v != v1;

            if (data)
            {
                name = "Alex";
            }
            else
            {
                name = "Joel";
            }

            name = data ? "Alex" : "Joel";


            Console.WriteLine("rta {0}", name);

            Console.ReadLine();
        



        }
    }
}
