namespace AulaPOO_Encapsulamento.classes
{
    public class MasterCard : Cartao
    {
        private int parcelas = 12;

        public int Parcelas
        {
            get{ return parcelas;} //Pegar os dados - Leitura
            set{ parcelas = value;} //Inserir os dados - Escrita
        }
        public string CompraComDesconto()
        {
            return "";
        }
    }

}