using System;

namespace PROYECTO1NETCORE
{
    class Program
    {
        static void Main(string[] args)
        {
            //int year = 10;
            //int twoyear = Convert.ToInt16("convertir datos de tipo String a int");//
            //double decimales = 2.5;
            //string nombre = "joe";
            //String nombres = "Alex";
            //decimal decimals = 2.8M;
            //float flotante = 8.0F;
            // decimal se puede usar cuando se tenga una cifra exacta, las float y double ocupan menos espacio//

            //bool valor = false;
            //falso o verdadero
            //char letra = 'a';
            //nsolo almacena un caracter en comillas simples
            //Decimal de = 3.32M;
            //Boolean valor1 = false;
            //solo maneja true o false

            //Console.WriteLine("Holaaaaaa tengo {0} {1} {2} {3} {4}", year , decimales, nombre, nombres, decimals);

            //Console.WriteLine("{0} {1} {2} {3}", valor, letra,de, valor1);

            //OPERADORES ARITMETICOS

            //int v = 10;
            //int v1 = 34;
            //var su = v+v1;
            //var re = v - v1;
            //var mul = v * v1;
            //var div = v / v1;
            //cualquier tipo de dato al realizar la operacion 

            //Console.WriteLine("{0}", su);
            //Console.WriteLine("{0}", re);
            //Console.WriteLine("{0}", mul);
            //Console.WriteLine("{0}", div);

            //OPERADORES DE ASIGNACION

            // int v = 10;
            //int v1 = 34;
            //v += v1; //incremento
            //v += v1;// decremento
            //v *= v1; //multiplicacion
            //v /= v1;//divide y asigna
            //v %= v1// divide el dato y muestra el residuo

            //Console.WriteLine("{0}", v);

            //OPERADORES DE COMPROBACION DE TIPOS Y RELACIONES
            //int v = 10;
            //int v1 = 34;
            //var data = v < v1;//comparar
            //var data1 = v > v1;
            //var data2 = v >= v1;
            //var data3 = v <= v1;
            //var data4 = v == v1;
            //var data5 = v != v1;
            //Console.WriteLine("{0}", data);
            //Console.WriteLine("{0}", data1);
            //Console.WriteLine("{0}", data2);
            //Console.WriteLine("{0}", data3);
            //Console.WriteLine("{0}", data4);
            //Console.WriteLine("{0}", data5);

            //IF Y OP CONDICIONALES

            int v = 23;
            int v1 = 12;
            double v2 = 10;
            double v3 = 13;
            var data5 = v != v1;

            if (data5)
            {
                Console.WriteLine("{0}", data5);
            }

            if(v != v1 )
            {
                Console.WriteLine("{0}", data5);
            }

            if (v != v1  && v2 == v3)
            {
                Console.WriteLine("rt{0}", data5);
            }
            if (v != v1 || v2 == v3)
            {
                Console.WriteLine("rta{0}", data5);
            }












            Console.ReadLine();





        }
    }
}
