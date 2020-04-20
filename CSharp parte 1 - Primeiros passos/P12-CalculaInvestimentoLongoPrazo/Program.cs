using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12 - Calcula investimento longo prazo \n");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            Console.WriteLine("Valor original: R$" + valorInvestido);

            for (int contadorAno = 0; contadorAno < 5; contadorAno++) {
                Console.WriteLine("----------" +
                    "\nAno: " + (contadorAno + 1) + "\n" +
                    "Fator de rendimento: " + fatorRendimento + "\n");
                for (int contadorMes = 0; contadorMes < 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("Mês " + (contadorMes + 1) + " - Valor: R$" + valorInvestido);
                }
                fatorRendimento += 0.001;
            }

            Console.WriteLine("\nExecução finalizada. \nAperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
