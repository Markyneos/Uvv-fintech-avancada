using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvvFintech.Model
{
    public class Corrente : Conta
    {
        public Corrente(string senha, Cliente dono) : base(senha, dono)
        {
        }
        public Corrente(string senha, Cliente dono, double saldoInicial) : base(senha, dono, saldoInicial)
        {
        }

        public override bool Sacar(double valor)
        {
            if (valor > _saldo)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }
        public bool Transferir(double valor, Conta destino, Transferencia.MetodoDePagamento metodo)
        {
            if (valor > _saldo)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                destino.Depositar(valor);
                Transferencia novaTransferencia = new(valor, this, destino, metodo);
                Transacoes.Add(novaTransferencia);
                destino.Transacoes.Add(novaTransferencia);
                return true;
            }
        }
    }
}
