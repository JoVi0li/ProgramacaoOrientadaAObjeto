namespace Aula_POO_ListasDeObjetoCartão.classes
{
    public class Cartao
    {
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Bandeira { get; set; }
        public string Vencimento { get; set; }
        public string CVV { get; set; }

        public Cartao()
        {

        }

        public Cartao(string _titular, string _numero, string _bandeira, string _vencimento, string _cvv)
        {
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Vencimento = _vencimento;
            this.CVV = _cvv;
        }
        
        
        
        
        
        
        
        
    }
}