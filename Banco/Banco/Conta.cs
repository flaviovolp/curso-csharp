using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {

        public int NumeroConta { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string nome, double depositoInicial)
        {
            NumeroConta = numeroConta;
            AlterarNomeConta(nome);
            Depositar(depositoInicial);
        }


        public void AlterarNomeConta(string nome)
        {
            Nome = nome;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo = Saldo - valor - 5.00;
        }

        public override string ToString()
        {
            return "Dados da conta atualizados: \n Conta "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture)
                + "\n";
        }
    }
}
