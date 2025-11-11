using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    internal class Depositar : ITransacao
    {
        private DateTime _dataHora;
        public DateTime DataHora { get => _dataHora; }
        private Conta _contaRelacionada;
        public Conta ContaRelacionada { get => _contaRelacionada; }
        private double _valor;
        public double Valor { get => _valor; }
        public override string ToString()
        {
            return $"Depósito:\nData/Hora: {DataHora}\nConta Relacionada: {ContaRelacionada}\nValor: {Valor}";
        }
    }
}
