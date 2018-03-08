using System;
using System.Collections.Generic;

namespace AppParte01
{
    public class MoneyParts
    {
        List<decimal> denominaciones;
        public MoneyParts()
        {
            denominaciones = new List<decimal>();
            denominaciones.Add(Convert.ToDecimal(0.05));
            denominaciones.Add(Convert.ToDecimal(0.1));
            denominaciones.Add(Convert.ToDecimal(0.2));
            denominaciones.Add(Convert.ToDecimal(0.5));
            denominaciones.Add(Convert.ToDecimal(1));
            denominaciones.Add(Convert.ToDecimal(2));
            denominaciones.Add(Convert.ToDecimal(5));
            denominaciones.Add(Convert.ToDecimal(10));
            denominaciones.Add(Convert.ToDecimal(20));
            denominaciones.Add(Convert.ToDecimal(50));
            denominaciones.Add(Convert.ToDecimal(100));
            denominaciones.Add(Convert.ToDecimal(200));
        }

        public string build(decimal entrada)
        {
            string salida = string.Empty;
            foreach(var denominacion in denominaciones)
            {
                if(entrada >= denominacion)
                {
                    if (entrada%denominacion == 0)
                    {
                        var dveces = entrada / denominacion;
                        var veces = Convert.ToInt32(dveces);
                        salida = salida + "[";
                        for (int i = 0; i < veces; i++)
                        {
                            salida = salida + denominacion + ", ";
                        }
                        salida = salida.Substring(0, salida.Length - 2) + "]  ";
                    }
                }
            }
            salida = salida.Substring(0, salida.Length - 2);
            return salida;
        }
    }
}