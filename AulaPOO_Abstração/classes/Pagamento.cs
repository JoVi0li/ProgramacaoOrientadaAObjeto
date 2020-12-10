using System;

namespace AulaPOO_Abstração.classes
{
    public abstract class Pagamento
    {
        private float valor;
        public float Valor
        {
            set{valor = value;}
            get{ return valor;}
        }
        protected DateTime data;
        public DateTime Data
        {
            get{return DateTime.Now;}
        }
        public string Cancelar()
        {
            return "";
        }
    }
}