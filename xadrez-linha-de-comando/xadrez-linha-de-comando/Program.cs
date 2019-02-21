using System;
using Tabuleiro;

namespace xadrez_linha_de_comando
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);
        }
    }
}
