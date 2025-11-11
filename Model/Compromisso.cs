namespace UVVFintechAvancada.Model
{
    public class Compromisso(string nome, string descricao, DateTime datahora, Calendario calendario)
    {
        private int _id;
        public int Id { get => _id; }
        private Calendario _calendario = calendario;
        public Calendario Calendario { get => _calendario; }
        public string Nome { get; set; } = nome;
        public string Descricao { get; set; } = descricao;
        public DateTime Datahora { get; set; } = datahora;

    }
}
