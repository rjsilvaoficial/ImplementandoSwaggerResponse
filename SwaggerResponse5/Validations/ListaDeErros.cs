using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerResponse5.Validations
{
    public class ListaDeErros
    {
        public ListaDeErros(IEnumerable<string> erros)
        {
            Erros = erros;
        }

        public IEnumerable<string> Erros { get; set; }
    }
}
