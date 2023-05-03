using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Entities
{
    public class AreaTrabalho
    {
        public int Id { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Background { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
