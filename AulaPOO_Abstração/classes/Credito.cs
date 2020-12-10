using System;

namespace AulaPOO_Abstração.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        public void Pagar(float valor)
        {
            if (valor <= this.limite)
            {
                int parcelas;
                do
                {
                    Console.WriteLine("Selecione a quantidade de parcelas: (1-12)");
                    parcelas = int.Parse(Console.ReadLine());
                    
                }while (parcelas > 12);

                float juros;
                if (parcelas <=6 && parcelas > 2)
                {
                    juros = 0.06f;
                }else{
                    juros = 0.08f;
                }
                
                float total = Valor + (this.Valor + juros);
                this.Valor = total;

                ExibirNota(this.Titular, total);
            }
            else
            {
                Console.WriteLine("Sem limite!!!");
            }
        }
        public void ExibirNota(string titular, float total)
        {
            Console.WriteLine($"Titular: {Titular} - Valor da compra: {total} ");
        }
    }
}