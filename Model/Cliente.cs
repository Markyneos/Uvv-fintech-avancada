namespace UVVFintechAvancada.Model
{
    public class Cliente
    {
        private int _id;
        public int Id { get { return _id; } }
        private string _nome;
        private string _email;
        private string _cpf;
        private string _rua;
        private int _numero;
        private string _complemento;
        private string _bairro;
        private string _cidade;
        private string _senha;
        private GerenciadorDeTransacoesCliente? _gerenTransacoes;

        public Cliente(string nome, string email, string cpf, string rua, int numero, string complemento, string bairro, string cidade, string senha)
        {
            _nome = nome;
            _email = email;
            _cpf = cpf;
            _rua = rua;
            _numero = numero;
            _complemento = complemento;
            _bairro = bairro;
            _cidade = cidade;
            _senha = senha;
            _gerenTransacoes = new GerenciadorDeTransacoesCliente(_id, this);
        }

        public List<Conta> Contas = new();
        public string Nome
        {
            get { return _nome; }
        }
        public string Email { get { return _email; } set { _email = value; } }
        public string Rua
        {
            get { return _rua; }
            set { _rua = value; }
        }
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public string Complemento { get { return _complemento; } set { _complemento = value; } }

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        public string Cidade { get { return _cidade; } set { _cidade = value; } }
        public string Senha { get { return _senha;  } set { _senha = value; } }

        public string Cpf { get => _cpf; }
        public GerenciadorDeTransacoesCliente? GerenTransacoes { get => _gerenTransacoes; }

        public void AdicionarConta(Conta c)
        {
            Contas.Add(c);
        }

    }
}
