namespace Sistema_de_Cadastro_de_Aluno.classes
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public string rg;
        public int idade;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        public float VerMediaFinal()
        {
            return this.mediaFinal;
        }

        public float VerMensalidade()
        {
            float valor;
            if (this.bolsista == true && this.mediaFinal >= 8)
            {
                valor = this.valorMensalidade * 0.5f;
            }else
            {
                valor = this.valorMensalidade;
            }
            return valor;
        }


    }
}