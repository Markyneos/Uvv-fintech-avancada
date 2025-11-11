using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFintechAvancada.Model
{
    public interface ITransacao
    {
        DateTime DataHora { get; }
        Conta ContaRelacionada { get; }
        double Valor { get; }

        public string ToString();
    }
}
