using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado.Exercicios.Exercicio06
{
    internal class JogoDaMemoria
    {
        public static void Memoria()
        {
            
            string[,] matriz = new string[6, 6] {
                {"cachorro", "Carro", "Moto", "jacaré", "Espátula", "Colher"},
                {"jacaré", "cachorro", "Espátula", "cobra", "gato", "Ônibus"},
                {"Avião", "leão", "elefante", "Moto", "Colher", "Escorredor"},
                {"Frigideira", "Barco", "Barco", "elefante", "Panela", "leão"},
                {"Frigideira", "gato", "Faca", "Faca", "Escorredor", "Caminhão"},
                {"Ônibus", "Avião", "Caminhão", "Panela", "cobra", "Carro"}
            };

            bool[,] acertos = new bool[6, 6];

            int paresEncontrados = 0;

            int ultimaLinha = -1;
            int ultimaColuna = -1;

            while (paresEncontrados < 6)
            {
                Console.Clear();
                Console.WriteLine("  1 2 3 4 5 6");
                Console.WriteLine("  +-+-+-+-+-+");

                for (int i = 0; i < 6; i++)
                {
                    Console.Write((i + 1).ToString() + "|");

                    for (int j = 0; j < 6; j++)
                    {
                        if (acertos[i, j])
                        {
                            Console.Write(matriz[i, j] + "|");
                        }
                        else
                        {
                            Console.Write(" |");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("  +-+-+-+-+-+\n");
                }


                Console.Write("\nDigite a linha: ");
                int linha = int.Parse(Console.ReadLine()) - 1;

                Console.Write("\nDigite a coluna: ");
                int coluna = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine();

                if (acertos[linha, coluna])
                {
                    Console.WriteLine("Carta já encontrada! Tente novamente.");
                }
                else
                {
                    Console.WriteLine("Carta selecionada: " + matriz[linha, coluna]);

                    if (ultimaLinha != -1 && ultimaColuna != -1)
                    {
                        if (matriz[linha, coluna] == matriz[ultimaLinha, ultimaColuna])
                        {
                            acertos[linha, coluna] = true;
                            acertos[ultimaLinha, ultimaColuna] = true;
                            paresEncontrados++;
                            Console.WriteLine("\nPar encontrado!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nNão foi dessa vez! Tente novamente.\n");
                        }

                        ultimaLinha = -1;
                        ultimaColuna = -1;
                    }
                    else
                    {
                        ultimaLinha = linha;
                        ultimaColuna = coluna;
                    }
                }

                Console.WriteLine("\nPressione ENTER para continuar...\n");
            }

            Console.WriteLine("\nParabéns! Você encontrou todos os pares!\n");
        }
    }
}
