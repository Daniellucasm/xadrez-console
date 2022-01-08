using tabuleiro;
using xadrez;

namespace xadrez_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            
            Console.ReadLine();
        }
    }
}
