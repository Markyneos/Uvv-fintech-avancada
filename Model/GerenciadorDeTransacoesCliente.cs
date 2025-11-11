using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    public class GerenciadorDeTransacoesCliente : IGerenciadorDeTransacoes
    {
        private int _idCliente;
        public int IdCliente { get => _idCliente; }
        private Cliente _clienteRelacionado;
        public Cliente ClienteRelacionado { get => _clienteRelacionado; }
        public IList<ITransacao> Transacoes { get; set; }

        public GerenciadorDeTransacoesCliente(int idCliente, Cliente cliente)
        {
            _idCliente = idCliente;
            _clienteRelacionado = cliente;
            Transacoes = new List<ITransacao>();
        }

        public void AdicionarTransacao(ITransacao transacao)
        {
            Transacoes.Add(transacao);
        }
    }
}
