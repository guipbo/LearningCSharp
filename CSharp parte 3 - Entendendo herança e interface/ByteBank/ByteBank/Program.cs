using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //CalcularBonificacao();

            UsarSistema();

            Console.WriteLine("\n**********" +
                "\nExecução finalizada." +
                "\nAperte ENTER para fechar...");
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("123.456.789-89");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("666.666.666-66");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "654";

            Console.Write("Roberta: ");
            sistemaInterno.Logar(roberta, "123");
            Console.Write("Camila: ");
            sistemaInterno.Logar(camila, "abc");
            Console.Write("Parceiro comercial: ");
            sistemaInterno.Logar(parceiro, "654");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("999.999.999-99");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("888.888.888-88");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("777.777.777-77");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("666.666.666-66");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("555.555.555-55");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações: R$" + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
