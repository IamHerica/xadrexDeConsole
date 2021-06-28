namespace tabuleiro
{
    abstract class Peca //classe abstrata pq possui um metodo abstrato
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }


        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();

            for (int contador = 0; contador < tab.linhas; contador++)
            {
                for (int contador2 = 0; contador2 < tab.colunas; contador2++)
                {
                    if (mat[contador, contador2]) //se verdadeiro
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }



        public abstract bool[,] movimentosPossiveis(); //nao tem implementacao pq é abstrato

    }
}
