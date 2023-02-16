using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de tormentas v0.1");
            // Variables iniciales
            int velocidad_delsonido = 343;
            int distancia;
            // Primero pregunto datos de partida
            Console.WriteLine("Dime cuántos segundos han pasado desde el rayo hasta el trueno");
            string tiempo = Console.ReadLine();
            int tiempoentero = int.Parse(tiempo);
            //Realizo operaciones con los datos de partida
            distancia = tiempoentero * velocidad_delsonido;
            // Muestro resultados en pantalla
            Console.WriteLine("La distancia a la tormenta es de:" + distancia + " metros");
        }
    }
}
