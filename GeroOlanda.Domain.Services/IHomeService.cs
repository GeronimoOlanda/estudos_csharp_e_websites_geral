using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Services
{
    public interface IHomeService
    {
        Task<IList<HomeDTO>> ConsultarDadosPorIdUsuario(decimal IdUsuario);

        public string CadastrarUma(string descricao);
        Task<ContatosDto> GetDadosContato(string Id, string telefone);
    }
}
