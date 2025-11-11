using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    public class GerenciadorDeClientes(int idBanco, Banco banco)
    {
        private int _id;
        public int Id { get => _id; }
        private int _idBanco = idBanco;
        public int IdBanco { get => _idBanco; }
        private Banco _bancoProprietario = banco;
        public Banco BancoProprietario { get => _bancoProprietario; }
        public List<Cliente> Clientes = new();

        public void AdicionarCliente(Cliente c)
        {
            Clientes.Add(c);
        }
    }
}
