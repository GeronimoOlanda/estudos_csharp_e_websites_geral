using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeroOlanda.Domain.Entities
{
    public class Home 
    {

        [Key]
        public int id_home { get; set; }

        public string Descricao { get; set; }
    }
}
