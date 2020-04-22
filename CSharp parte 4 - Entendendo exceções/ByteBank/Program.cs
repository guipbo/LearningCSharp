using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 867987);

            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Número: " + conta.Numero);

            ContaCorrente contaGabriela = new ContaCorrente(875, 875412);


            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("\n**********");
            Console.WriteLine("Excução finalizada. \nAperte ENTER para fechar...");
            Console.ReadLine();
        }
    }
}
