using System;
using tabuleiro;
using xadrez;

namespace xadrez_linha_de_comando
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro Tabuleiro = new Tabuleiro(8, 8);

            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Amarela), new Posicao(0, 0));
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Amarela), new Posicao(1, 3));
            Tabuleiro.ColocarPeca(new Rei(Tabuleiro, Cor.Amarela), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(Tabuleiro);
        }
    }
}
