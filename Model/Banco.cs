using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    public class Banco(string nome, GerenciadorDeClientes gCliente, GerenciadorDeContas gConta, GerenciadorDeTransacoesBanco gTransacao)
    {
        private int _id;
        public int Id { get => _id; }
        public string Nome = nome;
        public Calendario? Agenda { get; set; }
        public GerenciadorDeClientes? GClientes { get; set; } = gCliente;
        public GerenciadorDeContas? GContas { get; set; } = gConta;
        public GerenciadorDeTransacoesBanco? GTransacoes { get; set; } = gTransacao;

        public void AdicionarCompromisso(string nome, string descricao, DateTime dataHora)
        {
            if (Agenda != null)
            {
                Agenda.AdicionarCompromisso(new Compromisso(nome, descricao, dataHora, Agenda));
            }
            else
            {
                Agenda = new Calendario();
                Agenda.AdicionarCompromisso(new Compromisso(nome, descricao, dataHora, Agenda));
            }
        }
    }
}
