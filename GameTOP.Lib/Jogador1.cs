using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
        {

            //O jogador 1 implementa o iJogador (linha acima)
            public readonly string _Nome;

            public Jogador1(string nome = "Fallen")
            {
                _Nome = nome;
            }

            public string Chuta()
            {
                return $"{_Nome} chutou \n";
            }

            public string Corre()
            {
                return $"{_Nome} correu \n";
            }

            public string Passe()
            {
                return $"{_Nome} passou \n";
            }
        }
}