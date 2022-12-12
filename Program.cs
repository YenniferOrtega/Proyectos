using System;

namespace pruebaslogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cadenas = new string[5];
            cadenas[0] = "Yennifer ";
            cadenas[1] = "jose ";
            cadenas[2] = "Pablito ";
            cadenas[3] = "Luis ";
            cadenas[4] = "Carlos ";
            string[] name = {"Joel", " PDHN", "Pablito ", };
            int[] age = new int[5];
            age[0] = 5;
            age[1] = 15;
            age[2] = 50;
            age[3] = 55;
            age[4] = 95;


            Console.WriteLine("rta {0} {1}  {2}  {3} {4}", cadenas[0], cadenas[1], cadenas[2], cadenas[3], cadenas[4]);
            Console.WriteLine("rta {0}", cadenas[0] + " " + cadenas[3]);
            Console.WriteLine("rta {0}", cadenas[3] +" "+ name[2] + " age " + age[2]);
            Console.ReadLine();





        }
    }
}
