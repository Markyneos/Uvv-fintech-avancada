using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvvFintech.Model
{
    public class Cliente
    {
        private int _id;
        public int Id { get => _id; }
        private string _senha;
        public string Senha { get => _senha; }
        private string _cpf;
        public string Cpf { get => _cpf; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        private string _rua;
        private int _numero;
        private string _bairro;
        private string _cidade;
        public string Rua { get => _rua; }
        public int Numero { get => _numero; }
        public string Bairro { get => _bairro; }
        public string Cidade { get => _cidade; }
        public enum TiposDeConta
        {
            Corrente,
            Poupanca
        }
        public List<Conta> Contas = new();

        public Cliente(string senha, string cpf, string telefone, string email)
        {
            _senha = senha;
            _cpf = cpf;
            Telefone = telefone;
            Email = email;
        }

        public void AdicionarConta()
        {
            Contas.Add();
        }
        public void RemoverConta(int idConta)
        {
            Contas.Remove(Contas.Find(c => c.Id == idConta));
        }

        }
    }
