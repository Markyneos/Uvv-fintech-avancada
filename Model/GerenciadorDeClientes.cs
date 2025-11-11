using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    internal class GerenciadorDeClientes
    {
        private int _idBanco;
        public int IdBanco { get => _idBanco; }
        private Banco _bancoProprietario;
        public Banco BancoProprietario { get => _bancoProprietario; }
        public List<Cliente> Clientes = new();

        public void AdicionarCliente()
    }
}
