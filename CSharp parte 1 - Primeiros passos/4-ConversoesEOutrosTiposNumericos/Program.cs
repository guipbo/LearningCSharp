using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Conversões e outros tipos numéricos");

            double salario;
            salario = 1200.50;

            //O int é um tipo de variável de 32bit
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine("Salário: " + salario);
            Console.WriteLine("Salário em inteiro: " + salarioEmInteiro);

            //O long é um tipo de variável de 64bit
            long idade;
            idade = 1300000000000;

            //O short é um tipo de variável de 16bit
            short quantidadeProdutos = 15000;

            //Para usar o float, é necessário colocar o sufixo "f"
            float altura = 1.80f;

            Console.WriteLine("\nExecução finalizada. \nAperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
