using Atv03_AlgoritmoAvancado.Exercicios.Exercicio_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado
{
    internal class Exercicio06
    {
        public static void ExercicioAlgoritmo06()
        {
            Console.WriteLine("\nJogo da memória:\n");

            bool loop = true;

            while (loop)
            {
                Console.WriteLine("\nO que deseja fazer?:");
                Console.WriteLine("1 - Jogar jogo da memória" +
                    "\n2 - Limpar console" +
                    "\n3 - Sair\n");
                char escolha = Console.ReadKey().KeyChar;

                switch (escolha)
                {
                    case '1':
                        {
                            JogoDaMemoria.Memoria();
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
                            break;
                        }
                    case '3':
                        {
                            loop = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nDigite um valor válido!");
                            break;
                        }
                }
            }
        }
    }
}
