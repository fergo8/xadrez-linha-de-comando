using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "T";
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
            while (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                matriz[Posicao.Linha, Posicao.Coluna] = true;

                if(Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor) break;
                
                Posicao.Linha = Posicao.Linha - 1;
            }

            // posição leste
            Posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                matriz[Posicao.Linha, Posicao.Coluna] = true;

                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor) break;

                Posicao.Coluna = Posicao.Coluna + 1;
            }

            // posição sul
            Posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                matriz[Posicao.Linha, Posicao.Coluna] = true;

                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor) break;

                Posicao.Linha = Posicao.Linha + 1;
            }

            // posição oeste
            Posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                matriz[Posicao.Linha, Posicao.Coluna] = true;

                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor) break;

                Posicao.Coluna = Posicao.Coluna - 1;
            }
        }
    }
}
