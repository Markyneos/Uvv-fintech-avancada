namespace UVVFintechAvancada.Model
{
    class Compromisso(string nome, string descricao, DateTime datahora)
    {
        public string Nome { get; set; } = nome;
        public string Descricao { get; set; } = descricao;
        public DateTime Datahora { get; set; } = datahora;

    }
}
