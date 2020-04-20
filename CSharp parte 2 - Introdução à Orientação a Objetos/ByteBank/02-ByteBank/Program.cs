using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.saldo = 200;

            Console.WriteLine("Titular: " + conta.titular);
            Console.WriteLine("Agência: " + conta.agencia);
            Console.WriteLine("Número: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);

            Console.WriteLine("\n**********");
            Console.WriteLine("Excução finalizada. \nAperte ENTER para fechar...");
            Console.ReadLine();
        }
    }
}
