using JogoDeXadrez.tabuleiro;
using System.Text;

namespace JogoDeXadrez.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("R");
            return sb.ToString();
        }
    }       
}
