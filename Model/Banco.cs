using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    internal class Banco(string nome)
    {
        private int _id;
        public int Id { get => _id; }
        public string Nome = nome;
        public Calendario? Agenda { get; set; }
        public GerenciadorDeClientes GClientes { get; set; }
        public GerenciadorDeContas GContas { get; set; }
        public GerenciadorDeTransacoes GTransacoes { get; set; }
    }
}
