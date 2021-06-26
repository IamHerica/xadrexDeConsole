using System;
using tabuleiro;


namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }


        public Posicao toPosicao()//converter as posicoes do xadrez para matriz
        {
            return new Posicao(8 - linha, coluna - 'a');//codigo da letra escolhida - codigo de a
        }
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
