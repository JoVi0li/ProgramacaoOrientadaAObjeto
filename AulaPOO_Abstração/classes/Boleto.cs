using System;

namespace AulaPOO_Abstração.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras = "471328471374.90483091304.3i409ui3409.32904093128";
        public string CodigoDeBarras
        {
            get{return codigoDeBarras;}
        }
        public void Registrar(float valor, DateTime dataDeEmissao, string codigoDeBarras)
        {
            Console.WriteLine($"O valor da compra fica em R$ {valor*0.88f}");
            Console.WriteLine($"Data de emnissão: {dataDeEmissao}");
            Console.WriteLine($"Data de vencimento: {dataDeEmissao.AddDays(10)}");
            Console.WriteLine($"Código de barras: {codigoDeBarras}");
        }
    }
}