using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tabuleiro { get; private set; }
        private int Turno;
        private Cor JogadorAtual;

        public PartidaDeXadrez()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Rosa;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca Peca = Tabuleiro.RetirarPeca(origem);

            Peca.IncrementarQtdMovimentos();

            Peca PecaCapturada = Tabuleiro.RetirarPeca(destino);

            Tabuleiro.ColocarPeca(Peca, destino);
        }

        private void ColocarPecas()
        {
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Rosa), new PosicaoXadrez('C', 1).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Rosa), new PosicaoXadrez('C', 2).ToPosicao());
            Tabuleiro.ColocarPeca(new Rei(Tabuleiro, Cor.Azul), new PosicaoXadrez('C', 3).ToPosicao());
        }
    }
}
