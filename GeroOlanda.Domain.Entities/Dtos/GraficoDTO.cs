using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Entities.Dtos
{
    public class GraficoDTO
    {
        public int idGrafico { get; set; } 
        public int idUsuario { get; set; }
        
        public string TituloGrafico { get; set; }
        public string QtdElementos { get; set; }
        public string EixoX { get; set; }
        public string DescricaoEixoX { get; set; }
        public string DescricaoEixoY { get; set; }
        
        public string Descricao { get; set; }

    }
}
