using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeroOlanda.Domain.Entities
{
    public class Home 
    {
        public int Id { get; set; }

        [NotMapped]
        public string Descricao { get; set; }
    }
}
