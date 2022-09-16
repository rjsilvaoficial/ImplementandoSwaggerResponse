using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementandoSwaggerResponse1.Validations.Filters
{
    public class MeuFiltroPersonalizado : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errosEncontrados = new ListadoraDeErros(context.ModelState
                    .SelectMany(sm => sm.Value.Errors)
                    .Select(s => s.ErrorMessage));

                context.Result = new BadRequestObjectResult(errosEncontrados);
            }
        }
    }
}
