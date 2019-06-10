using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteGT4W.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DateNascimento { get; set; }
        public double Peso { get; set; }
        public string Uf { get; set; }
    }
}
