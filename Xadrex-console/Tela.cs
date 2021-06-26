using System;
using tabuleiro;
namespace Xadrex_console
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int linhas = 0; linhas < tab.linhas; linhas++)
            {
                for(int colunas = 0; colunas < tab.colunas; colunas++)
                {
                    if (tab.peca(linhas, colunas) == null)
                    {
                        Console.Write("- ");
                    }
                    Console.Write(tab.peca(linhas, colunas) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
