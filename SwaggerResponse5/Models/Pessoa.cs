using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerResponse5.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage ="sr3")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage ="sr3")]
        public string Profissao { get; set; }
    }
}
