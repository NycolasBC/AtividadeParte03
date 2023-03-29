using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado
{
    internal class Exercicio04
    {
        public static void ExercicioAlgoritmo04()
        {
            Console.WriteLine("\nWxercício 03:\n");

            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(0); j++)
                {
                    Console.WriteLine($"\nDigite o valor na posição [{i},{j}] da Matriz A.");
                    matrizA[i, j] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Digite o valor na posição [{i},{j}] da Matriz B.");
                    matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] somaMatriz = new int[3, 3];

            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(0); j++)
                {
                    somaMatriz[i, j] = matrizA[i, j] + matrizB[i, j];
                    Console.WriteLine($"A soma das linhas e colunas de ambas a matrizes na posição [{i},{j}] é {somaMatriz[i, j]}");
                }
            }
        }
    }
}
