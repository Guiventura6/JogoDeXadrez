﻿namespace JogoDeXadrez.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
        }

        public abstract bool[,] MovimentosPossiveis();

        public void IncrementarQtdMovimentos()
        {
            QtdMovimentos++;
        }
    }
}
