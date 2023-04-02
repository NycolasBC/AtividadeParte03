using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado.Exercicios.Exercicio_06
{
    internal class JogoDaMemoria
    {
        public static void Memoria()
        {
            string[] palavras = { "casa", "carro", "gato", "árvore", "livro", "computador",
                              "mesa", "cadeira", "pessoa", "telefone", "teclado", "abacaxi" };

            string[,] cartas = new string[6, 6];

            Random random = new Random();
            for (int i = 0; i < cartas.GetLength(0); i++)
            {
                for (int j = 0; j < cartas.GetLength(1); j++)
                {
                    int indice = random.Next(palavras.Length);
                    cartas[i, j] = palavras[indice];
                    cartas[i, j + 1] = palavras[indice];
                    j++;
                }
            }

            Console.WriteLine("\nBem-vindo ao jogo da memória!\n");
            for (int i = 0; i < cartas.GetLength(0); i++)
            {
                for (int j = 0; j < cartas.GetLength(1); j++)
                {
                    Console.Write(cartas[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int paresEncontrados = 0;
            while (paresEncontrados < 18)
            {
                Console.WriteLine("\nEscolha uma posição para revelar a carta (linha, coluna):");
                string[] escolha = Console.ReadLine().Split(' ');
                int linha = int.Parse(escolha[0]);
                int coluna = int.Parse(escolha[1]);

                if (cartas[linha, coluna] == null)
                {
                    Console.WriteLine("\nPosição inválida. Tente novamente.\n");
                }
                else if (cartas[linha, coluna] == "*")
                {
                    Console.WriteLine("\nCarta já revelada. Tente novamente.\n");
                }
                else
                {
                    Console.WriteLine("\nCarta revelada: " + cartas[linha, coluna]);
                    cartas[linha, coluna] = "*";

                    int ultimaCartaLinha = 0;
                    int ultimaCartaColuna = 0;

                    if (paresEncontrados % 2 == 0)
                    {
                        // Primeira carta
                        ultimaCartaLinha = linha;
                        ultimaCartaColuna = coluna;
                    }
                    else
                    {
                        // Segunda carta
                        if (cartas[ultimaCartaLinha, ultimaCartaColuna] == cartas[linha, coluna])
                        {
                            Console.WriteLine("\nPar encontrado!");
                            paresEncontrados++;
                            cartas[ultimaCartaLinha, ultimaCartaColuna] = "*";
                            cartas[linha, coluna] = "*";
                        }
                        else
                        {
                            Console.WriteLine("\nCartas não são iguais.");
                            cartas[ultimaCartaLinha, ultimaCartaColuna] = cartas[linha, coluna] = null;
                        }
                    }
                }
            }

            Console.WriteLine("\nParabéns, você encontrou todos os pares!\n");
        }
    }
}
