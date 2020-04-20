using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 3 - Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine("Salário: " + salario);

            double idade;
            idade = 15.0/2;

            Console.WriteLine("Idade: " + idade);            
            
            //C# trunca, pois um inteiro dividido por inteiro gera uma resposta em inteiro
            idade = 15/2;
            Console.WriteLine("Idade truncada: " + idade);

            Console.WriteLine("\nExecução finalizada. \nAperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
