using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "434.562.878-08";
            //gabriela.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "434.562.878-08";
            conta.titular.profissao = "Desenvolvedora C#";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563412;


            //Console.WriteLine("gabriela.nome: " + gabriela.nome);
            Console.WriteLine("conta.titular.nome: " + conta.titular.nome);
            Console.WriteLine("conta.titular.cpf: " + conta.titular.cpf);
            Console.WriteLine("conta.titular.profissao: " + conta.titular.profissao);

            Console.WriteLine("\n**********");
            Console.WriteLine("Excução finalizada. \nAperte ENTER para fechar...");
            Console.ReadLine();
        }
    }
}
