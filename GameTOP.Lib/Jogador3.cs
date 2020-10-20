using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Messi estas chutando \n";
        }

        public string Corre()
        {
            return "Messi estas correndo \n";
        }

        public string Passe()
        {
            return "Messi estas passando \n";
        }
    }
}