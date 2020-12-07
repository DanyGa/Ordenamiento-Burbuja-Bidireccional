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
            Program bb = new Program();
            bb.IngresarDatos();
            bb.BurbujaBidireccional();
        }

        private int[] vector; //variable global de tipo arreglo

        public void IngresarDatos()
        {
            Console.WriteLine("Metodo Burbuja Bidireccional");
            Console.Write("Longitud del vector: ");
            int cant;
            cant = int.Parse(Console.ReadLine());
            vector = new int[cant];
            for(int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese el elemento " + (f + 1) + " : ");
                vector[f] = int.Parse(Console.ReadLine());
            }
        }

        public void BurbujaBidireccional()
        {
            int b = 1;
            int aux = 0;
            int n = vector.Length;
            //ordena los numeros de mayor a menor
            for (int paso = 0; paso < vector.Length - 1 && b == 1; paso++)
            //si en el paso anterior no hubo cambios se detiene el ciclo
            {
                for (int j = 0; j < n - paso - 1; j++)
                //las comparaciones van disminuyendo a medida que se afectan los pasos
                {
                    if (vector[j] < vector[j + 1])
                    {
                        b = 1;
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
               
            }

            Console.WriteLine("Vector ordenado en forma descendente:");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + " ");
            }

            Console.ReadKey();
        }
    }
}
