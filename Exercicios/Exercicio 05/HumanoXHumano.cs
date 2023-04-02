﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado.Exercicios.Exercicio_05
{
    internal class HumanoXHumano : JogoDaVelha
    {
        public override void EscolhaDeJogo()
        {
            bool escolhaCorreta = true;

            while (escolhaCorreta)
            {
                Console.WriteLine("\nCom qual o primeiro jogador deseja jogar? X ou O");
                char escolha = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

                if (escolha == 'X')
                {
                    Jogador01 = escolha;
                    Jogador02 = 'O';
                    escolhaCorreta = false;
                }
                else if (escolha == 'O')
                {
                    Jogador01 = escolha;
                    Jogador02 = 'X';
                    escolhaCorreta = false;
                }
                else
                {
                    Console.WriteLine("\nDigite um valor válido!\n");
                }
            }
            
        }

        public override void FuncaoCalculo()
        {
            EscolhaDeJogo();

            char[,] tabela = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < tabela.GetLength(0); i++)
            {
                for (int j = 0; j < tabela.GetLength(1); j++)
                {
                    Console.Write($" {tabela[i, j]} |");
                }
                Console.WriteLine();
            }

            bool jogadas = true;

            bool vitoriaX_Linhas = true;
            bool vitoriaX_Colunas = true;
            bool vitoriaX_Cruzado = true;

            bool vitoriaO_Linhas = true;
            bool vitoriaO_Colunas = true;
            bool vitoriaO_Cruzado = true;

            while (vitoriaX_Linhas && vitoriaX_Colunas && vitoriaX_Cruzado && vitoriaO_Linhas && vitoriaO_Colunas && vitoriaO_Cruzado && jogadas)
            {
                jogadas = tabela[0, 0] != '1' && tabela[0, 1] != '2' && tabela[0, 2] != '3' && tabela[1, 0] != '4' && tabela[1, 1] != '5' && tabela[1, 2] != '6' && tabela[2, 0] != '7' && tabela[2, 1] != '8' && tabela[2, 2] != '9' ? false : true;

                vitoriaX_Linhas = (tabela[0, 0] == 'X' && tabela[0, 1] == 'X' && tabela[0, 2] == 'X') || (tabela[1, 0] == 'X' && tabela[1, 1] == 'X' && tabela[1, 2] == 'X') || (tabela[2, 0] == 'X' && tabela[2, 1] == 'X' && tabela[2, 2] == 'X') ? false : true;
                vitoriaX_Colunas = (tabela[0, 0] == 'X' && tabela[1, 0] == 'X' && tabela[2, 0] == 'X') || (tabela[0, 1] == 'X' && tabela[1, 1] == 'X' && tabela[2, 1] == 'X') || (tabela[0, 2] == 'X' && tabela[1, 2] == 'X' && tabela[2, 2] == 'X') ? false : true;
                vitoriaX_Cruzado = (tabela[0, 0] == 'X' && tabela[1, 1] == 'X' && tabela[2, 2] == 'X') || (tabela[0, 2] == 'X' && tabela[1, 1] == 'X' && tabela[2, 0] == 'X') ? false : true;

                vitoriaO_Linhas = (tabela[0, 0] == 'O' && tabela[0, 1] == 'O' && tabela[0, 2] == 'O') || (tabela[1, 0] == 'O' && tabela[1, 1] == 'O' && tabela[1, 2] == 'O') || (tabela[2, 0] == 'O' && tabela[2, 1] == 'O' && tabela[2, 2] == 'O') ? false : true;
                vitoriaO_Colunas = (tabela[0, 0] == 'O' && tabela[1, 0] == 'O' && tabela[2, 0] == 'O') || (tabela[0, 1] == 'O' && tabela[1, 1] == 'O' && tabela[2, 1] == 'O') || (tabela[0, 2] == 'O' && tabela[1, 2] == 'O' && tabela[2, 2] == 'O') ? false : true;
                vitoriaO_Cruzado = (tabela[0, 0] == 'O' && tabela[1, 1] == 'O' && tabela[2, 2] == 'O') || (tabela[0, 2] == 'O' && tabela[1, 1] == 'O' && tabela[2, 0] == 'O') ? false : true;

                if (vitoriaX_Linhas && vitoriaX_Colunas && vitoriaX_Cruzado && vitoriaO_Linhas && vitoriaO_Colunas && vitoriaO_Cruzado && jogadas)
                {
                    JogadaTabuleiro(tabela, Jogador01);
                }

                jogadas = tabela[0, 0] != '1' && tabela[0, 1] != '2' && tabela[0, 2] != '3' && tabela[1, 0] != '4' && tabela[1, 1] != '5' && tabela[1, 2] != '6' && tabela[2, 0] != '7' && tabela[2, 1] != '8' && tabela[2, 2] != '9' ? false : true;

                vitoriaX_Linhas = (tabela[0, 0] == 'X' && tabela[0, 1] == 'X' && tabela[0, 2] == 'X') || (tabela[1, 0] == 'X' && tabela[1, 1] == 'X' && tabela[1, 2] == 'X') || (tabela[2, 0] == 'X' && tabela[2, 1] == 'X' && tabela[2, 2] == 'X') ? false : true;
                vitoriaX_Colunas = (tabela[0, 0] == 'X' && tabela[1, 0] == 'X' && tabela[2, 0] == 'X') || (tabela[0, 1] == 'X' && tabela[1, 1] == 'X' && tabela[2, 1] == 'X') || (tabela[0, 2] == 'X' && tabela[1, 2] == 'X' && tabela[2, 2] == 'X') ? false : true;
                vitoriaX_Cruzado = (tabela[0, 0] == 'X' && tabela[1, 1] == 'X' && tabela[2, 2] == 'X') || (tabela[0, 2] == 'X' && tabela[1, 1] == 'X' && tabela[2, 0] == 'X') ? false : true;

                vitoriaO_Linhas = (tabela[0, 0] == 'O' && tabela[0, 1] == 'O' && tabela[0, 2] == 'O') || (tabela[1, 0] == 'O' && tabela[1, 1] == 'O' && tabela[1, 2] == 'O') || (tabela[2, 0] == 'O' && tabela[2, 1] == 'O' && tabela[2, 2] == 'O') ? false : true;
                vitoriaO_Colunas = (tabela[0, 0] == 'O' && tabela[1, 0] == 'O' && tabela[2, 0] == 'O') || (tabela[0, 1] == 'O' && tabela[1, 1] == 'O' && tabela[2, 1] == 'O') || (tabela[0, 2] == 'O' && tabela[1, 2] == 'O' && tabela[2, 2] == 'O') ? false : true;
                vitoriaO_Cruzado = (tabela[0, 0] == 'O' && tabela[1, 1] == 'O' && tabela[2, 2] == 'O') || (tabela[0, 2] == 'O' && tabela[1, 1] == 'O' && tabela[2, 0] == 'O') ? false : true;
            

                if (vitoriaX_Linhas && vitoriaX_Colunas && vitoriaX_Cruzado && vitoriaO_Linhas && vitoriaO_Colunas && vitoriaO_Cruzado && jogadas)
                {
                    JogadaTabuleiro(tabela, Jogador02);
                }
            }


            if (!vitoriaX_Linhas || !vitoriaX_Colunas || !vitoriaX_Cruzado)
            {
                Console.WriteLine("\n\nVITÓRIA DO X\n\n");
            }
            else if (!vitoriaO_Linhas || !vitoriaO_Colunas || !vitoriaO_Cruzado)
            {
                Console.WriteLine("\n\nVITÓRIA DO O\n\n");
            }
            else
            {
                Console.WriteLine("\n\nEMPATE\n\n");
            }

            Console.WriteLine("\nFim da partida!\n");
        }



        private void JogadaTabuleiro(char[,] tabela, char jogador)
        {
            jogueDeNovo:

            Console.WriteLine($"\nQual posição o jogador {jogador} deseja jogar?");
            char escolhaJogador = Console.ReadKey().KeyChar;

            switch (escolhaJogador)
            {
                case '1':
                    {
                        if (tabela[0, 0] == '1')
                        {
                            tabela[0, 0] = jogador;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                            goto jogueDeNovo;
                        }
                        break;
                    }
                case '2':
                    {
                        if (tabela[0, 1] == '2')
                        {
                            tabela[0, 1] = jogador;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                            goto jogueDeNovo;
                        }
                        break;
                    }
                case '3':
                    {
                        if (tabela[0, 2] == '3')
                        {
                            tabela[0, 2] = jogador;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                            goto jogueDeNovo;
                        }
                        break;
                    }
                case '4':
                    {
                        if (tabela[1, 0] == '4')
                        {
                            tabela[1, 0] = jogador;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                            goto jogueDeNovo;
                        }
                        break;
                    }
                case '5':
                    {
                        if (tabela[1, 1] == '5')
                        {
                            tabela[1, 1] = jogador;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                            goto jogueDeNovo;
                        }
                        break;
                    }
                case '6':
                    {
                        if (tabela[1, 2] == '6')
                        {
                            tabela[1, 2] = jogador;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                            goto jogueDeNovo;
                        }
                        break;
                    }
                case '7':
                    {
                        if (tabela[2, 0] == '7')
                        {
                            tabela[2, 0] = jogador;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                            goto jogueDeNovo;
                        }
                        break;
                    }
                case '8':
                    {
                        if (tabela[2, 1] == '8')
                        {
                            tabela[2, 1] = jogador;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                            goto jogueDeNovo;
                        }
                        break;
                    }
                case '9':
                    {
                        if (tabela[2, 2] == '9')
                        {
                            tabela[2, 2] = jogador;
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                            goto jogueDeNovo;
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\nEscolha um valor válido!\n");
                        goto jogueDeNovo;
                    }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Clear();

            for (int i = 0; i < tabela.GetLength(0); i++)
            {
                for (int j = 0; j < tabela.GetLength(1); j++)
                {
                    Console.Write($" {tabela[i, j]} |");
                }
                Console.WriteLine();
            }
        }
    }
}
