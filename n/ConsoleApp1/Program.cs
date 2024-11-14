
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos elementos quieres en el arreglo?: ");
            int cantidadElementos = int.Parse(Console.ReadLine());
            int[] arreglo = new int[cantidadElementos];
            Random rnd = new Random();

            for (int i = 0; i < cantidadElementos; i++)
            {
                arreglo[i] = rnd.Next(50, 91);
            }
            Console.WriteLine("Arreglo generado:");
            foreach (int num in arreglo)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("¿Prefieres números pares o impares? (Escribe 'pares' o 'impares'): ");
            string preferencia = Console.ReadLine().Trim().ToLower();
            int contador = 0;
            if (preferencia == "pares")
            {
                foreach (int num in arreglo)
                {
                    if (num % 2 == 0)
                    {
                        contador++;
                    }
                }
                Console.WriteLine($"Cantidad de números pares: {contador}");
            }
            else if (preferencia == "impares")
            {
                foreach (int num in arreglo)
                {
                    if (num % 2 != 0)
                    {
                        contador = contador + 1;
                    }
                }
                Console.WriteLine($"Cantidad de números impares: {contador}");
            }
            else
            {
                Console.WriteLine("Preferencia no reconocida. Por favor, escribe 'pares' o 'impares'.");
            }
        }
    }
}
