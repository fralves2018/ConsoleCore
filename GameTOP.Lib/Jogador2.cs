using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maratona estas chutando \n";
        }

        public string Corre()
        {
            return "Maratona estas correndo \n";
        }

        public string Passe()
        {
            return "Maratona estas passando \n";
        }
    }
}