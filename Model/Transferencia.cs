using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvvFintech.Model
{
    public class Transferencia : ITransacao
    {
        private int _id;
        public int Id { get => _id; }
        private double _valor;
        public double Valor { get => _valor; }
        private Conta _contaRelacionada;
        public Conta ContaRelacionada { get => _contaRelacionada; }
        private Conta _contaRelacionada2;
        public Conta ContaRelacionada2 { get => _contaRelacionada2; }
        private DateTime _dataHora;
        public DateTime DataHora { get => _dataHora; }
        public enum MetodoDePagamento
        {
           Pix,
           Credito,
           Debito,
           Boleto
        }
        private MetodoDePagamento _metodo;
        public MetodoDePagamento Metodo { get => _metodo; }

        public bool Autorizar()
        {
            return ContaRelacionada.Transacoes.Contains(this) && ContaRelacionada2.Transacoes.Contains(this);
        }
        public string GerarComprovante()
        {
            return $"Id: {Id}\nValor: {Valor}\nConta Relacionada 1: {ContaRelacionada}\nConta Relacionada 2: {ContaRelacionada2}\nData/Hora: {DataHora}\nMétodo de Pagamento: {Metodo}";
        }
        public Transferencia(double valor, Conta conta1, Conta conta2, MetodoDePagamento metodo)
        {
            _valor = valor;
            _contaRelacionada = conta1;
            _contaRelacionada2 = conta2;
            _metodo = metodo;
            _dataHora = DateTime.Now;
        }
    }
}
