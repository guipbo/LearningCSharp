using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }

        //get público e set privado
        public static int TotalDeContasCriadas { get; private set; }
        public int ContSaquesNaoPermitidos { get; private set; }
        public int ContTransferenciasNaoPermitidas { get; private set; }

        //No readonly o valor só pode ser atribuído no construtor
        public readonly int _numero;
        public int Numero {
            get
            {
                return _numero;
            }
        }
        //Escrita sem o set é equivalente ao readonly
        public int Agencia { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value >= 0)
                    this._saldo = value;
            }
        }

        public ContaCorrente (int numeroAgencia, int numeroConta)
        {

            if (numeroAgencia <= 0)
                throw new ArgumentException("A Agência deve ser maior que zero.", nameof(numeroAgencia));
            if (numeroConta <= 0)
                throw new ArgumentException("O Número deve ser maior que zero.", nameof(numeroConta));

            Agencia = numeroAgencia;
            _numero = numeroConta;

            ContaCorrente.TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));

            if (this._saldo < valor)
            {
                ContSaquesNaoPermitidos++;   
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            this._saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
                throw new ArgumentException("Valor inválido para transferência.", nameof(valor));

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada", ex);
            }
            contaDestino.Depositar(valor);

        }
    }
}