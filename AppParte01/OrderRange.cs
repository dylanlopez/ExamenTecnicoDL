using System.Collections.Generic;

namespace AppParte01
{
    public class OrderRange
    {
        public string build (List<int> entrada)
        {
            string salida = string.Empty;
            List<List<int>> respuesta = new List<List<int>>();
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            foreach (int numero in entrada)
            {
                if (numero%2 == 0)
                {
                    pares.Add(numero);
                }
                else
                {
                    impares.Add(numero);
                }
            }
            respuesta.Add(pares);
            respuesta.Add(impares);
            salida = salida + "[";
            foreach(var par in pares)
            {
                salida = salida + par + ", ";
            }
            salida = salida.Substring(0, salida.Length - 2) + "]  ";
            salida = salida + "[";
            foreach (var impar in impares)
            {
                salida = salida + impar + ", ";
            }
            salida = salida.Substring(0, salida.Length - 2) + "]";
            return salida;
            //return respuesta;
        }
    }
}