using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SwaggerResponse2.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerResponse2.Filters
{
    public class MeuFiltro : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var listaDeErros = new ListaDeErros(context.ModelState
                    .SelectMany(sm => sm.Value.Errors)
                    .Select(s => s.ErrorMessage));

                context.Result = new BadRequestObjectResult(listaDeErros);

            }
        }
    }
}
