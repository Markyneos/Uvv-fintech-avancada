using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace UVVFintechAvancada.Model
{
    public abstract class Conta
    {
        private int _id;
        public int Id { get { return _id; } }
        private string _senha;
        public string Senha { get { return _senha; } }
        private double _saldo;
        public double Saldo { get { return _saldo; } }
        public Cliente Dono { get; set; }

        public abstract void AplicarRendimento();
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

    }
}
