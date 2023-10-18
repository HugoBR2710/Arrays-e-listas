using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAutenticacao autenticacao = new AutenticacaoServico();

            bool autenticado = autenticacao.LogIn("123", "123");

            if (autenticado)
            {
                Console.WriteLine("Utilizador autenticado com sucesso");
                autenticacao.LogOut();
            }
            else
            {
                Console.WriteLine("Falha na autenticação");
            }
        }
    }
}
