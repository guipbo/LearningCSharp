using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela =  new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;
            contaGabriela.saldo = 100.00;

            Console.WriteLine("***********\n");
            Console.WriteLine("Titular: " + contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);
            Console.WriteLine("Número: " + contaGabriela.numero);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);


            Console.WriteLine("\n**********");
            Console.WriteLine("Excução finalizada. \nAperte ENTER para fechar...");
            Console.ReadLine();
        }
    }
}
