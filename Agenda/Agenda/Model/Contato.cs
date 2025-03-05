using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Model {
    public class Contato {
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Campo requerido")]
        [MaxLength(30, ErrorMessage ="Nome deve ter no max. 30 caracteres")]
        [MinLength(3, ErrorMessage="Nome deve ter no min. 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Campo requerido")]
        [RegularExpression(@"^\d{2}\s?\d{4,5}\s?\d{4}$", ErrorMessage ="Número de telefone inválido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage ="Campo requerido")]
        [EmailAddress(ErrorMessage ="E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Campo requerido")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        public string FotoUrl { get; set; }

        [NotMapped]
        public IFormFile Foto {  get; set; }
    }
}
