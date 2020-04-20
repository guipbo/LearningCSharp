using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;            
            
            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.numero = 863452;

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaGabriela == contaGabrielaCosta));
            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            contaGabriela = contaGabrielaCosta;

            Console.WriteLine("Igualdade de tipo de referência (contaGabriela = contaGabrielaCosta): " + (contaGabriela == contaGabrielaCosta));

            contaGabriela.saldo = 300;
            
            Console.WriteLine("\n\nO saldo impresso é o mesmo pois ambas apontam para a mesma posição na memória.");
            Console.WriteLine("Saldo contaGabriela: " + contaGabriela.saldo);
            Console.WriteLine("Saldo contaGabrielaCosta: " + contaGabrielaCosta.saldo);

            Console.WriteLine("\n**********");
            Console.WriteLine("Excução finalizada. \nAperte ENTER para fechar...");
            Console.ReadLine();
        }
    }
}
