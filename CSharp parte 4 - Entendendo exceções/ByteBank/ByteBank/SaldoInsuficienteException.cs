using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException(){}
        //Com o this, da mesma forma que o base eu chamo outro construtor.
        //A diferença é que o this chama o construtor da mesma classe.
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Saldo insuficiente para saque." +
                  "\nSaldo: R$" + saldo +
                  "\nSaque: R$" + valorSaque)
        {
            this.Saldo = saldo;
            this.ValorSaque = valorSaque;
        }
        //Construtor chamado pelo this do construtor acima
        public SaldoInsuficienteException(string mensagem) 
            : base(mensagem){}
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) 
            : base(mensagem, excecaoInterna) {}

    }
}
