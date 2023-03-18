using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado
{
    internal class Exercicio02
    {
        public static void ExercicioAlgoritmo02()
        {
            Console.WriteLine("\nExercício 02:\n");

            double[,] matriz = new double[3, 3] { { 2.3, 5.1, 3.0 }, { 1.5, 4.3, 7.0 }, { 8.3, 9.0, 11.3 } };
            double[] mediaMatriz = new double[3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                double media = 0.0;
                double soma = 0.0;


                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    soma += matriz[j, i];
                }

                media = soma / 2.0;

                mediaMatriz[i] = media;
            }

            for (int i = 0; i < mediaMatriz.Length; i++)
            {
                Console.WriteLine($"A média da coluna {i} é: {mediaMatriz[i]:F2}");
            }
        }
    }
}
