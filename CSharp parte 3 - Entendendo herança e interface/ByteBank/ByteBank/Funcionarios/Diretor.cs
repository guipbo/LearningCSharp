using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel, IAutenticavel
    {
        //Necessário criar um método construtor, pois a classe funcionário tem um e recebe um parâmetro nele
        public Diretor(string cpf) : base(5000, cpf){}

        //virtual e override são o polimorfismo
        public override double GetBonificacao()
        {
            //base chama o GetBonificacao do funcionario (da classe base)
            return Salario *= 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
