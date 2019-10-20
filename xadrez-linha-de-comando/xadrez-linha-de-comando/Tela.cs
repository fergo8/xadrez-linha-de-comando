﻿using System;
using tabuleiro;

namespace xadrez_linha_de_comando
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if(tabuleiro.Peca(i, j) != null)
                        Console.Write(tabuleiro.Peca(i, j) + " ");
                    else
                        Console.Write("- ");
                }
                Console.WriteLine();
            }
        }
    }
}