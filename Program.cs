using System;

namespace pruebaslogin
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] name = { "alex", "Joel", "pdhn" };
            int[] age = { 52, 45, 65 };
            //for (int i = 0; i <  name.Length; i++)
            //{
            //    Console.WriteLine("rta {0}", name[i] + " age " + age[i]);
            //}
            foreach (var item in name)
            {
                Console.WriteLine("rta {0}", item);
            }
            Console.ReadLine();
        



        }
    }
}
