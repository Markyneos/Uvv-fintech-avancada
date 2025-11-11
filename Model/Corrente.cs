using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    internal class Corrente : Conta
    {
        private static double _taxaDeRendimento = 0.0030;
        public double TaxaDeRendiento { get => _taxaDeRendimento; set { _taxaDeRendimento = value; } }

        public Corrente(Cliente dono, string senha) : base(dono, senha)
        {

        }
        public override void AplicarRendimento()
        {
            base.Saldo += base.Saldo * _taxaDeRendimento;
        }
    }
}
