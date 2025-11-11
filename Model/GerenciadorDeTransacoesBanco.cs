using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    public class GerenciadorDeTransacoesBanco : IGerenciadorDeTransacoes
    {
        private int _bancoId;
        public int BancoId { get => _bancoId; }
        private Banco _banco;
        public Banco Banco { get => _banco; }
        public IList<ITransacao> Transacoes { get; set; }

        public GerenciadorDeTransacoesBanco(int bancoId, Banco banco)
        {
            _bancoId = bancoId;
            _banco = banco;
            Transacoes = new List<ITransacao>();
        }
        public void AdicionarTransacao(ITransacao transacao)
        {
            Transacoes.Add(transacao);
        }
    }
}
