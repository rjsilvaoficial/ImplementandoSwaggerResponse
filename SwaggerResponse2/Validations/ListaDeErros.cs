using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerResponse2.Validations
{
    public class ListaDeErros
    {
        public IEnumerable<string> Erros { get; private set; }

        public ListaDeErros(IEnumerable<string> erros)
        {
            Erros = erros;
        }

    }
}
