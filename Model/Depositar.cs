using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    public class Depositar : ITransacao
    {
        private int _id;
        public int Id { get => _id; }
        private DateTime _dataHora;
        public DateTime DataHora { get => _dataHora; }
        private Conta _contaRelacionada;
        public Conta ContaRelacionada { get => _contaRelacionada; }
        private double _valor;
        public double Valor { get => _valor; }

        public Depositar(Conta c, double v)
        {
            _dataHora = DateTime.Now;
            _contaRelacionada = c;
            _valor = v;
        }
        public override string ToString()
        {
            return $"Depósito:\nData/Hora: {DataHora}\nConta Relacionada: {ContaRelacionada}\nValor: {Valor}";
        }
    }
}
