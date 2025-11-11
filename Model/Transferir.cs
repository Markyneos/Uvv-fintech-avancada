using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    internal class Transferir
    {
        private DateTime _dataHora;
        public DateTime DataHora { get => _dataHora; }
        private Conta _contaRelacionada;
        public Conta ContaRelacionada { get => _contaRelacionada; }
        private Conta _contaRelacionada2;
        public Conta ContaRelacionada2 { get => _contaRelacionada2; }
        private double _valor;
        public double Valor { get => _valor; }
        public override string ToString()
        {
            return $"Transferência:\nData/Hora: {DataHora}\nConta Relacionada 1: {ContaRelacionada}\nConta Relacionada 2: {ContaRelacionada2}\nValor: {Valor}";
        }
    }
}
