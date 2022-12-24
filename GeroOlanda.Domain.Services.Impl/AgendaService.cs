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

        public IList<AgendaDTO> ConsultarDadosAgenda(int idIntervencao, string Descricao)
        {
            var response = _agendaRepository.ConsultarDadosAgenda(idIntervencao, Descricao);
            return response;
        }

        public AgendaDTO CriarDadosAgenda(AgendaDTO agendaDTO)
        {
            var response = _agendaRepository.CriarDadosAgenda(agendaDTO);

            return response;
        }
    }
}