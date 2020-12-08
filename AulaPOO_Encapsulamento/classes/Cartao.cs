namespace AulaPOO_Encapsulamento.classes
{
    public class Cartao
    {
        private string numero = "5262 0406 0326 4050 ";
        private string bandeira = "MasterCard";
        protected string token = "acdefg";
        private string cvv = "867";
        private float limite  = 5000;


        public string Numero
        {
            get{ return numero;}
        }
        public string Bandeira
        {
            get{ return bandeira;}
        }
        public string Cvv
        {
            get{return cvv;}
        }
        public float Limite
        {
            get{return limite;}
        }

        public string RegistrarCompra(bool validado)
        {
            return "";
        }

        private bool ValidarCompra(float saldo)
        {
            return true;
        }

        protected string ValidarToken(string token)
        {
            return "";
        }
    }

}