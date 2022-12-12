using GeroOlanda.API.Models.Contatos;

namespace GeroOlanda.API.Models.Home
{
    public class HomeModel
    {

        public int IdHome { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public string RodapeDescricao { get; set; }

        ContatosModel Contatos { get; set; }
    }
}
