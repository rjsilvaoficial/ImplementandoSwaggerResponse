using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementandoSwaggerResponse1.Validations
{
    public class ListadoraDeErros
    {
        public IEnumerable<string> Erros { get; }
        public ListadoraDeErros(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
