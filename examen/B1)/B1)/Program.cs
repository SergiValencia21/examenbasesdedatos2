using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de cuanto tiempo queda");
            // Variables iniciales

            // Primero pregunto datos de partida
            Console.WriteLine("Dime a qué velocidad va tu coche");
            string velocidad = Console.ReadLine();
            Console.WriteLine("Dime a qué distancia está el lugar al que vas");
            string distancia = Console.ReadLine();
            // Realizo operaciones con los datos de partida
            float velocidad_entero = float.Parse(velocidad);
            float distancia_entero = float.Parse(distancia);
            float tiempo = distancia_entero / velocidad_entero;
            // Muestro resultados en pantalla
            Console.WriteLine("Vas a tardar en llegar " + tiempo + "horas");
        }
    }
}
