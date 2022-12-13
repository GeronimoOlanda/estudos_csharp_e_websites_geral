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
    }
}
