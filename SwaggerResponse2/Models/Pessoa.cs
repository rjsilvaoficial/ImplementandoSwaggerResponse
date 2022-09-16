using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerResponse2.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Precisa Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Precisa Profissao")]
        public string Profissao { get; set; }
    }
}
