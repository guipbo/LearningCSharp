using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula poupança2\n");

            double valorInvestido = 1000;

            Console.WriteLine("Valor original: R$" + valorInvestido + "\n");

            for(int contadorMes = 0; contadorMes < 12; contadorMes++)
            {
                valorInvestido *= 1+(0.36 / 100);
                Console.WriteLine("Após " + (contadorMes+1) + " mês, você terá: R$" + valorInvestido);
            }

            Console.WriteLine("\nExecução finalizada. \nAperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
