using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Entities.Dtos
{
    public class AreaTrabalhoDTO
    {
        public int Id { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        

       

    }
}
