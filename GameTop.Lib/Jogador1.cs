namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        public string Corre()
        {
            return $"{_Nome} está Correndo \n";
        }

        public string Chuta()
        {
             return $"{_Nome} está Chutando \n";
        }
        public string Passe()
        {
             return $"{_Nome} está Passando \n";
        }
    }
}