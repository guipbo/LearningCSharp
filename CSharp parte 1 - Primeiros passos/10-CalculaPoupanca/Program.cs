using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança \n");

            int contadorMes = 1;
            double valorInvestido = 1000;

            Console.WriteLine("Valor original: R$" + valorInvestido + "\n");

            while (contadorMes <= 12)
            {
                Console.WriteLine("Após " + contadorMes + " mês, você terá: R$" + valorInvestido);
                valorInvestido += valorInvestido * (0.36 / 100);
                contadorMes++;
            }

            Console.WriteLine("\nExecução finalizada. \nAperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
