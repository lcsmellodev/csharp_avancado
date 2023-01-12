using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaBancaria
{
    internal class Conta
    {
       
        public int Numero { get; }
        public string Titular { get; private set; }
        public double SaldoInicial { get; }
        public double Saldo { get;  private set; }


        public Conta(int numero, string titular, double saldoInicial)
        {
            Numero = numero;
            Titular = titular;
            SaldoInicial = saldoInicial;
            Saldo = saldoInicial;
            
        }

        public override string ToString()
        {
            return $"Dados da conta :\n Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo}";
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }



    }
}
