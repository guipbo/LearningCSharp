using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //abstract me impede de instanciar um objeto da classe funcionario, tenho que instanciar um objeto de alguma classe filha da funcionario
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        //protected só pode ser acessado pela classe e pelas classes filhas 
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            this.Cpf = cpf;
            this.Salario = salario;

            TotalFuncionarios++;
        }

        //abstract obriga que o método seja sobrescrito nas classes filhas
        public abstract void AumentarSalario();
        public abstract double GetBonificacao();

        //virtual e override são o polimorfismo
        //public virtual double GetBonificacao()
        //{
        //    Console.WriteLine("Atenção, não esqueça de sobrescrever o método GetBonificacao()");
        //    return 0;
        //}
    }
}
