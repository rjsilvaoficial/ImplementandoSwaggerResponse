using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerResponse3.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "SR3")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "SR3")]
        public string Descricao { get; set; }
    }
}
