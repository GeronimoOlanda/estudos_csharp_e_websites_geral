using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Repository
{
    public interface IAgendaRepository
    {
        AgendaDTO CriarDadosAgenda(AgendaDTO agendaDTO);
        IList<AgendaDTO> ConsultarDadosAgenda(AgendaDTO consultarAgenda);
        void SaveChanges();

    }
}
