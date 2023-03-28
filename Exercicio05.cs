using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado
{
    internal class Exercicio05
    {
        public static void ExercicioAlgoritmo05()
        {
            Console.WriteLine("\nWxercício 05:\n");

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("\nMenu:\n");

                Console.WriteLine("1 - Iniciar novo jogo Humano vs Humano" +
                    "\n2 - Iniciar novo jogo Humano vs Máquina" +
                    "\n3 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            HumanoXHumano humanoXHumano = new HumanoXHumano();
                            humanoXHumano.FuncaoCalculo();
                            break;
                        }

                    case 2:
                        {
                            HumanoXMaquina humanoXMaquina = new HumanoXMaquina();
                            humanoXMaquina.FuncaoCalculo();
                            break;
                        }

                    case 3:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("\nDigite um valor válido!\n");
                        break;
                }
            }
            Console.WriteLine("\nFim do jogo!\n");   
        }
    }




    abstract class JogoDaVelha
    {
        protected char Jogador01 { get; set; }
        protected char Jogador02 { get; set; }

        public virtual void FuncaoCalculo()
        {

        }
    }


    internal class HumanoXHumano : JogoDaVelha
    {
        private void EscolhaDeJogo()
        {
            Console.WriteLine("\nCom qual o primeiro jogador deseja jogar? X ou O");
            char escolha = Char.ToUpper(Console.ReadKey().KeyChar);

            if (escolha == 'X')
            {
                Jogador01 = escolha;
                Jogador02 = 'O';
            }
            else if (escolha == 'O')
            {
                Jogador01 = escolha;
                Jogador02 = 'X';
            }
            else
            {
                Console.WriteLine("\nDigite um valor válido!\n");
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

            int jogadas = 0;

            while (jogadas != 9)
            {
                jogueDeNovo:

                Console.WriteLine("\nQual posição o jogador 1 deseja jogar?");
                char escolhaJogador01 = Console.ReadKey().KeyChar;

                switch (escolhaJogador01)
                {
                    case '1':
                        {
                            if (tabela[0, 0] == '1')
                            {
                                jogadas++;
                                tabela[0, 0] = Jogador01;
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
                                jogadas++;
                                tabela[0, 1] = Jogador01;
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
                                jogadas++;
                                tabela[0, 2] = Jogador01;
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
                                jogadas++;
                                tabela[1, 0] = Jogador01;
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
                                jogadas++;
                                tabela[1, 1] = Jogador01;
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
                                jogadas++;
                                tabela[1, 2] = Jogador01;
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
                                jogadas++;
                                tabela[2, 0] = Jogador01;
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
                                jogadas++;
                                tabela[2, 1] = Jogador01;
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
                                jogadas++;
                                tabela[2, 2] = Jogador01;
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

                for (int i = 0; i < tabela.GetLength(0); i++)
                {
                    for (int j = 0; j < tabela.GetLength(1); j++)
                    {
                        Console.Write($" {tabela[i, j]} |");
                    }
                    Console.WriteLine();
                }

                if (jogadas != 9)
                {
                    jogueDeNovo2:

                    Console.WriteLine("\nQual posição o jogador 2 deseja jogar?");
                    char escolhaJogador02 = Console.ReadKey().KeyChar;

                    switch (escolhaJogador02)
                    {
                        case '1':
                            {
                                if (tabela[0, 0] == '1')
                                {
                                    jogadas++;
                                    tabela[0, 0] = Jogador02;
                                }
                                else
                                {
                                    Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                                    goto jogueDeNovo2;
                                }
                                break;
                            }
                        case '2':
                            {
                                if (tabela[0, 1] == '2')
                                {
                                    jogadas++;
                                    tabela[0, 1] = Jogador02;
                                }
                                else
                                {
                                    Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                                    goto jogueDeNovo2;
                                }
                                break;
                            }
                        case '3':
                            {
                                if (tabela[0, 2] == '3')
                                {
                                    jogadas++;
                                    tabela[0, 2] = Jogador02;
                                }
                                else
                                {
                                    Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                                    goto jogueDeNovo2;
                                }
                                break;
                            }
                        case '4':
                            {
                                if (tabela[1, 0] == '4')
                                {
                                    jogadas++;
                                    tabela[1, 0] = Jogador02;
                                }
                                else
                                {
                                    Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                                    goto jogueDeNovo2;
                                }
                                break;
                            }
                        case '5':
                            {
                                if (tabela[1, 1] == '5')
                                {
                                    jogadas++;
                                    tabela[1, 1] = Jogador02;
                                }
                                else
                                {
                                    Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                                    goto jogueDeNovo2;
                                }
                                break;
                            }
                        case '6':
                            {
                                if (tabela[1, 2] == '6')
                                {
                                    jogadas++;
                                    tabela[1, 2] = Jogador02;
                                }
                                else
                                {
                                    Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                                    goto jogueDeNovo2;
                                }
                                break;
                            }
                        case '7':
                            {
                                if (tabela[2, 0] == '7')
                                {
                                    jogadas++;
                                    tabela[2, 0] = Jogador02;
                                }
                                else
                                {
                                    Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                                    goto jogueDeNovo2;
                                }
                                break;
                            }
                        case '8':
                            {
                                if (tabela[2, 1] == '8')
                                {
                                    jogadas++;
                                    tabela[2, 1] = Jogador02;
                                }
                                else
                                {
                                    Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                                    goto jogueDeNovo2;
                                }
                                break;
                            }
                        case '9':
                            {
                                if (tabela[2, 2] == '9')
                                {
                                    jogadas++;
                                    tabela[2, 2] = Jogador02;
                                }
                                else
                                {
                                    Console.WriteLine("\nEscolha outra opção pois essa já foi preenchida.\n");
                                    goto jogueDeNovo2;
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\nEscolha um valor válido!\n");
                                goto jogueDeNovo2;
                            }
                    }
                    Console.WriteLine($"\nJogadas: {jogadas}\n");

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
                }  
            }

            if (jogadas == 9)
            {
                Console.WriteLine("\nEMPATE\n");
            }
            Console.WriteLine("\nFim da partida!\n");
        }
    }


    internal class HumanoXMaquina : JogoDaVelha
    {
        private void EscolhaDeJogo()
        {
            Console.WriteLine("\nCom qual o primeiro jogador deseja jogar? X ou O");
            char escolha = Char.ToUpper(Console.ReadKey().KeyChar);

            if (escolha == 'X')
            {
                Jogador01 = escolha;
                Jogador02 = 'O';
            }
            else if (escolha == 'O')
            {
                Jogador01 = escolha;
                Jogador02 = 'X';
            }
            else
            {
                Console.WriteLine("\nDigite um valor válido!\n");
            }
        }

        public override void FuncaoCalculo()
        {
            
        }
    }
}
