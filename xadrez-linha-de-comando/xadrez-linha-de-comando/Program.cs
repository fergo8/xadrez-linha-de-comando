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
                Tabuleiro Tabuleiro = new Tabuleiro(8, 8);

                Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Amarela), new Posicao(0, 0));
                Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branca), new Posicao(1, 3));
                Tabuleiro.ColocarPeca(new Rei(Tabuleiro, Cor.Amarela), new Posicao(2, 4));

                Tela.ImprimirTabuleiro(Tabuleiro);
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
