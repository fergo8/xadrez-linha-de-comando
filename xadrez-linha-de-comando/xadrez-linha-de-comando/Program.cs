using System;
using tabuleiro;
using xadrez;

namespace xadrez_linha_de_comando
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez Partida = new PartidaDeXadrez();
                //Tabuleiro Tabuleiro = new Tabuleiro(8, 8);
                
                Tela.ImprimirTabuleiro(Partida.Tabuleiro);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //PosicaoXadrez posicao = new PosicaoXadrez('C', 7);

            //Console.WriteLine(posicao);
            //Console.WriteLine(posicao.ToPosicao());
        }
    }
}
