namespace PrimeiroPOO
{
    public class Personagem
    {
        public string nome;
        public string armadura;
        public int idade;

        public string Atacar(){
            return "Ataque de fogo!";
        }
        public string Defender(){
            return "Não foi dessa vez!";
        }

    }
}