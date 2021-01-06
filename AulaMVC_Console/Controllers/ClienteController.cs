using System.Collections.Generic;
using AulaMVC_Console.Models;
using AulaMVC_Console.Views;

namespace AulaMVC_Console.Controllers
{
    public class ClienteController
    {
        Cliente cliente = new Cliente();

        ClienteView clienteView = new ClienteView();

        public void MostrarCliente()
        {
            List<Cliente> todos = cliente.Ler();
            clienteView.ListarTodos(todos);

        }

        public void CadastrarCliente()
        {
            cliente.Inserir(clienteView.CadastrarCliente());
        }
    }
}