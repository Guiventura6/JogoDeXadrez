using JogoDeXadrez.tabuleiro;
using System.Text;

namespace JogoDeXadrez.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("T");
            return sb.ToString();
        }
    }
}
