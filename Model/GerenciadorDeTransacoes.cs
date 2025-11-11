using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    internal class GerenciadorDeTransacoes
    {
        private int? _idConta;
        private Conta? _contaRelacionada;

        private int? _idBanco;
        public int? IdBanco { get => _idBanco; }
        private Banco? _banco;
        public Banco? Banco { get => _banco; }

        public GerenciadorDeTransacoes(int idConta, Conta contaRelacionada)
        {
            _idConta = idConta;
            _contaRelacionada = contaRelacionada;
            _idBanco = null;
            _banco = null;
        }
        public GerenciadorDeTransacoes(int idBanco, Banco banco)
        {
            _idConta = null;
            _contaRelacionada = null;
            _idBanco = idBanco;
            _banco = banco;
        }

        public int? IdConta { get => _idConta; }
        public Conta? ContaRelacionada { get => _contaRelacionada; }
        public List<ITransacao> Transacoes = new();

        public void AdicionarTransacao(ITransacao transacao)
        {
            Transacoes.Add(transacao);
        }
    }
}
