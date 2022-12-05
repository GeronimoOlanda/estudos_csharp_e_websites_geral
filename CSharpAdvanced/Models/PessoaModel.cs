using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Models
{
    public class PessoaModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataAtual { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
