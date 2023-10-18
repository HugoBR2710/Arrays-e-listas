using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class AutenticacaoServico : IAutenticacao
{
	public bool logIn(string usuario, string password)
	{
		if(usuario == "123" && password == "123")
        {
			return true;

        }
        else
        {
            return false;
        }
	}

    public void LogOut()
    {
        Console.WriteLine("LogOut");
    }
}
