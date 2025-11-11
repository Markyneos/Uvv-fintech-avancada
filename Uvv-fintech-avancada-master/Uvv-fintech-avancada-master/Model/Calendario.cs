namespace UVVFintechAvancada.Model
{
    class Calendario
    {
        private int _id;
        public int Id { get { return _id; } }
        List<Compromisso> compromissos = new List<Compromisso>();

        public bool AdicionarCompromisso(Compromisso compromisso)
        {
            compromissos.Add(compromisso);
            return compromissos.Contains(compromisso);
        }

    }
}
