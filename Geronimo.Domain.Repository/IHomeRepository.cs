using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Repository
{
    public interface IHomeRepository
    {
        Task<IList<HomeDTO>> ConsultarDadosPorIdUsuario(decimal IdUsuario);
        void SaveChanges();
        Task<IList<Home>> Cadastrar(string Descricao);

        public string CadastrarUma(string descricao);

        public ContatosDto GetDadosContato(string Id, string telefone);

    }
}
