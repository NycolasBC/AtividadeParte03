using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado
{
    internal class Exercicio01
    {
        public static void ExercicioAlgoritmo01()
        {
            Console.WriteLine("\nExercício 01:\n");

            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.WriteLine($"\nDigite o valor da matriz na posição [{i},{j}]\n");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int maiorElemento = matriz.Cast<int>().Max();
            Console.WriteLine($"\nO maior valor da Matriz é {maiorElemento}\n");

            int somaElemento = matriz.Cast<int>().Sum();
            Console.WriteLine($"\nA soma dos elementos da Matriz é {somaElemento}\n");

            int primoElemento = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    if (matriz[i, j] % 2 != 0)
                    {
                        primoElemento += 1;
                    }
                }
            }

            Console.WriteLine($"\nA quantidade de valores primos na Matriz é {primoElemento}\n");
        }
    }
}
