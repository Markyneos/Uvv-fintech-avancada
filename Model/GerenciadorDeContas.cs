using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    public class GerenciadorDeContas(Banco bancoGerenciador, int bancoId)
    {
        public enum TipoDeConta
        {
            Corrente,
            Poupanca
        }
        private int _bancoId = bancoId;
        public int BancoId { get => _bancoId; }
        private Banco _bancoGerenciador = bancoGerenciador;
        public Banco BancoGerenciador { get => _bancoGerenciador; }
        public List<Conta> Contas = new();

        public void DeletarConta(Conta c)
        {
            Contas.Remove(c);
        }
        public void CriarConta(Cliente dono, string senha, TipoDeConta tipo)
        {
           switch (tipo)
            {
                case TipoDeConta.Poupanca:
                    Contas.Add(new Poupanca(dono, senha));
                    break;
                case TipoDeConta.Corrente:
                    Contas.Add(new Corrente(dono, senha));
                    break;
                default:
                    Console.WriteLine("ERRO: Deve-se inserir as opções de conta: 'Corrente' ou 'Poupanca'");
                    break;
            }
        }
    }
}
