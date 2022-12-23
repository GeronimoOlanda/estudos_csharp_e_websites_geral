using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Repository;
using GeroOlanda.Domain.Services;

namespace GeroOlanda.Domain.Services.Impl
{
    public class AgendaService :IAgendaService
    {
        private readonly IAgendaRepository _agendaRepository;
        public AgendaService()
        {
           
        }
        public AgendaService(IAgendaRepository agendaRepository)
        {
            _agendaRepository = agendaRepository;
        }

        public IList<AgendaDTO> ConsultarDadosAgenda(AgendaDTO consultarAgenda)
        {
            throw new NotImplementedException();
        }

        public AgendaDTO CriarDadosAgenda(AgendaDTO agendaDTO)
        {
            throw new NotImplementedException();
        }
    }
}