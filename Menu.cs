using Atv03_AlgoritmoAvancado.Exercicios.Exercicio06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado
{
    internal class Menu
    {
        public static void MenuGeral()
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("\nMenu:\n");
                Console.WriteLine
                    ("\nEscolha uma das opções:" +
                        "\n1 - Exercício 01" +
                        "\n2 - Exercício 02" +
                        "\n3 - Exercício 03" +
                        "\n4 - Exercício 04" +
                        "\n5 - Exercício 05" +
                        "\n6 - Exercício 06" +
                        "\n7 - Limpar console" +
                        "\n8 - Sair"
                    );
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Exercicio01.ExercicioAlgoritmo01();
                        break;

                    case 2:
                        Exercicio02.ExercicioAlgoritmo02();
                        break;

                    case 3:
                        Exercicio03.ExercicioAlgoritmo03();
                        break;

                    case 4:
                        Exercicio04.ExercicioAlgoritmo04();
                        break;

                    case 5:
                        Exercicio05.ExercicioAlgoritmo05();
                        break;

                    case 6:
                        Exercicio06.ExercicioAlgoritmo06();
                        break;

                    case 7:
                        Console.Clear();
                        break;

                    case 8:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("\nEscreva um valor válido!\n");
                        break;
                }
            }
            Console.WriteLine("\nFim do programa!");
        }
    }
}
