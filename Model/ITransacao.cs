using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvvFintech.Model
{
    public interface ITransacao
    {
        int Id { get; }
        double Valor { get; }
        Conta ContaRelacionada { get; }
        DateTime DataHora { get; }
        enum MetodoDePagamento;

        public bool Autorizar();
        public string GerarComprovante();
    }
}
