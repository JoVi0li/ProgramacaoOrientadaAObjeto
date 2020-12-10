namespace AulaPOO_PolimorfismoSobreposicao.classes
{
    public abstract class Player
    {
        private float velocidade;
        private float forcaPulo;

        public  virtual string  Correr()
    {
        return "Correndo em velocidade 1x";
    }
    }
}