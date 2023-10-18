using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

internal class AutenticacaoServico : IAutenticacao
{
	public bool LogIn(string utilizador, string password)
	{
		if(utilizador == "123" && password == "123")
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
