using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado
{
    internal class Exercicio03
    {
        public static void ExercicioAlgoritmo03()
        {
            Console.WriteLine("\nWxercício 03:\n");

            int[,] matriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrizTransposta = new int[3, 3];

            for (int i = 0; i < matrizTransposta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizTransposta.GetLength(0); j++)
                {
                    matrizTransposta[j, i] = matriz[i, j];
                }
            }

            Console.WriteLine("\nMatriz:\n");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($" {matriz[i, j]} ");
                }

                Console.WriteLine();
            }


            Console.WriteLine("\nMatriz Transposta:\n");

            for (int i = 0; i < matrizTransposta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizTransposta.GetLength(1); j++)
                {
                    Console.Write($" {matrizTransposta[i, j]} ");
                }

                Console.WriteLine();
            }
        } 
    }
}
