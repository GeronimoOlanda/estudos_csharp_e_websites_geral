using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Entities.Dtos
{
    public class InformacoesDTO
    {
        public int IfFormulario { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
       
        public EnderecoDTO Enderecos { get; set; }
    }
}
