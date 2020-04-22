using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarregarContas();


            Console.WriteLine("\n\n**********");
            Console.WriteLine("Excução finalizada. \nAperte ENTER para fechar...");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {

            using(LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            //Mesma lógica do bloco acima
            //-----------------------------------------------------
            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Erro: " + e.Message);
            //}
            //finally
            //{
            //    if(leitor != null)
            //        leitor.Fechar();
            //}

        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 456987);
                ContaCorrente conta2 = new ContaCorrente(123, 123987);

                conta.Transferir(10000, conta2);

                conta.Depositar(50);
                Console.WriteLine("Saldo: R$" + conta.Saldo);
                conta.Sacar(500);
                Console.WriteLine("Saldo após saque: R$" + conta.Saldo);

            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine("Erro: " + e.Message);
                Console.WriteLine("\n**********" +
                    "\nTrace: \n" + e.StackTrace);

                Console.WriteLine("\n*********** INNER EXCEPTION **********");
                Console.WriteLine("Erro: " + e.InnerException.Message);
                Console.WriteLine("\n**********" +
                    "\nTrace: \n" + e.InnerException.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                Console.WriteLine("\n**********" +
                    "\nTrace: \n" + e.StackTrace);

                Console.WriteLine("\n*********** INNER EXCEPTION **********");
                Console.WriteLine("Erro: " + e.InnerException.Message);
                Console.WriteLine("\n**********" +
                    "\nTrace: \n" + e.InnerException.StackTrace);
            }
        }
    }
}