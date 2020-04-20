using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.Cpf = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";


            conta.Saldo = -10;
            conta.Titular = cliente;
            Console.WriteLine("Titular: " + conta.Titular.Nome);
            Console.WriteLine("Saldo: " + conta.Saldo);

            Console.WriteLine("\n**********");
            Console.WriteLine("Excução finalizada. \nAperte ENTER para fechar...");
            Console.ReadLine();
        }
    }
}
