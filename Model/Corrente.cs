using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    public class Corrente(Cliente dono, string senha, Banco banco, int idBanco) : Conta(dono, senha, banco, idBanco)
    {
        private static double _taxaDeRendimento = 0.0030;
        public double TaxaDeRendimento { get => _taxaDeRendimento; set { _taxaDeRendimento = value; } }

        public override void AplicarRendimento()
        {
            base.Saldo += base.Saldo * _taxaDeRendimento;
        }
    }
}
