using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    internal class Sacar : ITransacao
    {
        private DateTime _dataHora;
        public DateTime DataHora { get => _dataHora; }
        private Conta _contaRelacionada;
        public Conta ContaRelacionada { get => _contaRelacionada; }
        private double _valor;
        public double Valor { get => _valor; }
        public override string ToString()
        {
            return $"Saque:\nData/Hora: {DataHora}\nConta Relacionada: {ContaRelacionada}\nValor: {Valor}";
        }
    }
}
