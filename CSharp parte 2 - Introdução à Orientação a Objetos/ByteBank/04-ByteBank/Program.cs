using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";


            if (contaBruno.Sacar(75))
                Console.WriteLine("Saldo atualizado após saque: R$" + contaBruno.saldo);
            else
                Console.WriteLine("\nSaldo insuficiente. \nSaldo atual: R$" + contaBruno.saldo);

            contaBruno.Depositar(500);
                Console.WriteLine("\nSaldo atualizado após depósito: R$" + contaBruno.saldo);

            ContaCorrente contaGabriela = new ContaCorrente();

            if (contaBruno.Transferir(200, contaGabriela))
                Console.WriteLine("\nTransferência efetuada com sucesso!" +
                    "\nSaldo atualizado: R$" + contaBruno.saldo);
            else
                Console.WriteLine("\nSaldo insuficiente. \nSaldo atual: R$" + contaBruno.saldo);


            Console.WriteLine("\n**********");
            Console.WriteLine("Excução finalizada. \nAperte ENTER para fechar...");
            Console.ReadLine();
        }
    }
}
