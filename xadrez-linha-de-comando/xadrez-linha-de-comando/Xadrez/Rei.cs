using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca Peca = Tabuleiro.Peca(posicao);
            return Peca == null || Peca.Cor != Cor;
        }

        public override bool[,] MovimentosPosiveis()
        {
            bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao Posicao = new Posicao(0, 0);

            // posição norte
            Posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);

            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
                matriz[Posicao.Linha, Posicao.Coluna] = true;

            // posição nordeste
            Posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
                matriz[Posicao.Linha, Posicao.Coluna] = true;

            // posição leste
            Posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
                matriz[Posicao.Linha, Posicao.Coluna] = true;

            // posição sudeste
            Posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
                matriz[Posicao.Linha, Posicao.Coluna] = true;

            // posição sul
            Posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);

            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
                matriz[Posicao.Linha, Posicao.Coluna] = true;

            // posição sudoeste
            Posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
                matriz[Posicao.Linha, Posicao.Coluna] = true;

            // posição oeste
            Posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
                matriz[Posicao.Linha, Posicao.Coluna] = true;

            // posição noroeste
            Posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
                matriz[Posicao.Linha, Posicao.Coluna] = true;
        }
    }
}
