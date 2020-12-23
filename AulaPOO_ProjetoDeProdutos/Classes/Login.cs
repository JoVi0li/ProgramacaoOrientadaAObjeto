using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login
    {
        public bool Logado {get; set;}

        public Login()
        {
            Usuario user =  new Usuario();
            user.Cadastrar();
            Logar(user);

            if (Logado)
            {
                GerarMenu();
            }
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            int escolha = 0;

            do
            {
                Console.WriteLine($"Escolha uma das opções abaixo:");

                Console.WriteLine($"[1] - Cadastrar Produto || [2] - Listar Produtos || [3] - Deletar produto");

                Console.WriteLine($"[4] - Cadastrar Marca || [5] - Listar Marcas || [6] - Deletar Marca");

                Console.WriteLine($"[0] - Sair");

                escolha = int.Parse(Console.ReadLine());
    
                switch (escolha)
                {
                    case 1:
                        produto.Cadastrar();
                        break;

                    case 2:
                        produto.Listar();
                        break;

                    case 3:
                        Console.WriteLine($"Digite um código para excluir:");
                        int cod = int.Parse(Console.ReadLine());
                        produto.Deletar(cod);
                        break;

                    case 4:
                        marca.CadastrarMarca();
                        break;

                    case 5:
                        marca.Listar();
                        break;

                    case 6:
                        Console.WriteLine($"Digite um código para excluir:");
                        int codMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codMarca);
                        break;

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Programa encerrado");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção inválida!");
                        Console.ResetColor();
                        break;
                }
                                
            } while (escolha != 0);
        }

        public void Logar(Usuario usuario)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("//LOGIN//");
            Console.ResetColor();

            Console.WriteLine("Digite seu e-mail");
            string emailLogin = Console.ReadLine();
            
            Console.WriteLine("Digite sua senha:");
            string senhaLogin = Console.ReadLine();
            
            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha)
            {
                Logado = true;

                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login efetuado com sucesso!");
                Console.ResetColor();
            }else{

                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Login NÃO efetuado!");
                Console.ResetColor();

            }
            
        }

    }

}
