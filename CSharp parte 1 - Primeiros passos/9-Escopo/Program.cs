using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            int quantidadePessoas = 2;

            bool idade = idadeJoao >= 18;
            bool acompanhado = quantidadePessoas >= 2;

            string mensagemAdicional = "";

            if (acompanhado)
                mensagemAdicional = "Está acompanhado!";
            else
                mensagemAdicional = "Não está acompanhado!";
                

            if (idade && acompanhado)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }

            Console.WriteLine("\nExecução finalizada. \nAperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
