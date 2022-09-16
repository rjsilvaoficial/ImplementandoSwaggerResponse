using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerResponse1.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Nome é necessário")]
        public string Nome { get; set; }

        [Required(ErrorMessage =  "Profissão é necessário")]
        public string Profissao { get; set; }


    }
}
