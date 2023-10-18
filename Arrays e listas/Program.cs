using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_e_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do array:");
            string N = Console.ReadLine();

            //Verificacao do input para converter para inteiro

            if(int.TryParse(N, out int numero))
            {
                //Declaracao do array do tamanho introduzido pelo utilizador
                int[] numeros = new int[numero];
                //Ciclo para introduzir numeros do 0 ao numero do tamanho selecionado
                for (int i = 1; i < numero; i++)
                {
                    numeros[i] = i;
                    Console.Write("{0}", numeros[i]);
                }

                Console.WriteLine("\nIntroduza o numero do espaco do array que deseja verificar o dado (de 0 a {0}): ", numero);
                string input = Console.ReadLine();

                if(int.TryParse(input, out int inpuInt))
                {
                    int buscaElemento = numeros[inpuInt];
                    Console.WriteLine("O numero selecionado {0}", buscaElemento);
                    Console.ReadKey();
                }
            }
            
        }
    }
}
