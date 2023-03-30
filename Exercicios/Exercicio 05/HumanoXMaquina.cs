using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv03_AlgoritmoAvancado.Exercicios.Exercicio_05
{
    internal class HumanoXMaquina : JogoDaVelha
    {
        public override void EscolhaDeJogo()
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
