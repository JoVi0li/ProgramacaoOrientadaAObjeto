using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario
    {

        public int Codigo { get; set; } = 01;
        
        public string Nome { get; set; } = "João Vitor";
        
        public string Email { get; set; } = "joao@gmail.com";
        
        public string Senha { get; set; } = "123";
        
        public DateTime DataCadastro { get; set; } = DateTime.UtcNow;
        
        
        public void Cadastrar()
        {
            Codigo = Codigo;
            Nome = Nome;
            Email = Email;
            Senha = Senha;
        }

        public void Deletar() 
        {
            Email = "";
            Nome = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
    }
}