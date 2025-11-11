using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    internal class Poupanca : Conta
    {
        private static double _taxaDeRendimento = 0.0055;

        public Poupanca(Cliente dono, string senha) : base(dono, senha)
        {
        }

        public double TaxaDeRendiento { get => _taxaDeRendimento; set { _taxaDeRendimento = value; } }
        public override void AplicarRendimento()
        {
            base.Saldo += base.Saldo * _taxaDeRendimento;
        }
    }
}
