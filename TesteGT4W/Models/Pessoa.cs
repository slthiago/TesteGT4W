using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteGT4W.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DateNascimento { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public double Peso { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Uf { get; set; }
    }
}
