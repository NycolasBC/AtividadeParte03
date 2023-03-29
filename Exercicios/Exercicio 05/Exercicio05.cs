using Atv03_AlgoritmoAvancado.Exercicios.Exercicio_05;
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
}
