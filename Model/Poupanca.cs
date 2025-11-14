using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvvFintech.Model
{
    public class Poupanca : Conta
    {
        protected static double taxaDeRendimento = 0.0055;
        protected static double taxaDeSaque = 0.012;

        public Poupanca(string senha, Cliente dono) : base(senha, dono) {}

        public Poupanca(string senha, Cliente dono, double saldoInicial) : base(senha, dono, saldoInicial) {}

        public override bool Sacar(double valor)
        {
            if ((valor * taxaDeSaque) + valor > _saldo)
            {
                return false;
            }
            else
            {
                _saldo -= (valor * taxaDeSaque) + valor;
                return true;
            }
        }
        public void AplicarRendimento()
        {
            _saldo += _saldo * taxaDeRendimento;
        }
    }
}
