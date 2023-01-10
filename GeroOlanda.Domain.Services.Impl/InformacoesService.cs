using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Repository;
using GeroOlanda.Domain.Services;

namespace GeroOlanda.Domain.Services.Impl
{
    public class InformacoesService :IInformacoesService
    {
        private readonly IAgendaRepository _agendaRepository;
        public InformacoesService()
        {
           
        }
        public InformacoesService(IAgendaRepository agendaRepository)
        {
            _agendaRepository = agendaRepository;
        }

        public InformacoesDTO CadastrarInformacoes(InformacoesDTO informacoesDTO)
        {
            throw new NotImplementedException();
        }

        public AgendaDTO CriarDadosAgenda(AgendaDTO agendaDTO)
        {
            var response = _agendaRepository.CriarDadosAgenda(agendaDTO);

            return response;
        }
    }
}