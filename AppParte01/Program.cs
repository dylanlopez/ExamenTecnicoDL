using System;
using System.Collections.Generic;

namespace AppParte01
{
    class Program
    {
        private static ChangeString cs = new ChangeString();
        private static OrderRange or = new OrderRange();
        private static MoneyParts mp = new MoneyParts();

        static void Main(string[] args)
        {
            /*
            Console.Write("Ingrese texto a cambiar: ");
            string a = Console.ReadLine();
            var salida = cs.build(a);
            Console.WriteLine("");
            Console.WriteLine("Respuesta: " + salida);
            */
            /*
            Console.WriteLine("Ingresando números: 2, 5, 7, 8, 12, 13, 20");
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(5);
            list.Add(7);
            list.Add(8);
            list.Add(12);
            list.Add(13);
            list.Add(20);
            var salida = or.build(list);
            Console.WriteLine("");
            Console.WriteLine("Respuesta: " + salida);
            */
            /*
            Console.Write("Ingrese denominacion: ");
            string sentrada = Console.ReadLine();
            decimal entrada = Convert.ToDecimal(sentrada);
            var salida = mp.build(entrada);
            Console.WriteLine("");
            Console.WriteLine("Respuesta: " + salida);
            */

            Console.ReadLine();
        }
    }
}