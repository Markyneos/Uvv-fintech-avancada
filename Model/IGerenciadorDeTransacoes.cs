using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    public interface IGerenciadorDeTransacoes
    {
        //        private int? _idCliente;
        //        private Cliente? _clienteRelacionado;
        //
        //        private int? _idBanco;
        //        public int? IdBanco { get => _idBanco; }
        //        private Banco? _banco;
        //        public Banco? Banco { get => _banco; }

        //public int? IdConta { get => _idCliente; }
        //public Cliente? ContaRelacionada { get => _clienteRelacionado; }
        IList<ITransacao> Transacoes { get; set; }

        public void AdicionarTransacao(ITransacao transacao);
    }
}
