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

                while (!Partida.Terminada)
                {
                    Console.Clear();

                    Tela.ImprimirTabuleiro(Partida.Tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    Partida.ExecutarMovimento(origem, destino);
                }
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
