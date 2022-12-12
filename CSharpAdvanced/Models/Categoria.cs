using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Models
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Titullo  { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public DateTime DataCriacaoBase { get
            {
                return DateTime.Now;
            }
        }

        public string ObterTitulos
        {
            get
            {
                return Titullo + "U+0020-U+0020" + Descricao;
            }
        }
    }
}
