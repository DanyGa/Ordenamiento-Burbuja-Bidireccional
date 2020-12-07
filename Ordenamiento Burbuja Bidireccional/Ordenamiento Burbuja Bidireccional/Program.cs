using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_Burbuja_Bidireccional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodo Burbuja - Ordenamiento de un vector (Arreglo)
            int n;
            Console.Write("Escriba la cantidad de numeros: ");
            n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Numero {0}: ", (i + 1));
                vector[i] = int.Parse(Console.ReadLine());
            }

            //Metodo Burbuja
            for (int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    int aux;
                    if(vector[i] > vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }

            Console.WriteLine("Datos ordenados: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
    }
}
