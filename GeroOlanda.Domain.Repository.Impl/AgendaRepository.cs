using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Repository.Impl.GeroDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Repository.Impl
{
    public class AgendaRepository : IAgendaRepository
    {
        protected GeroOlandaDbContext _context;

        public AgendaRepository(GeroOlandaDbContext context)
        {
            _context = context;
        }
        public AgendaRepository()
        {

        }

        public AgendaDTO CriarDadosAgenda(AgendaDTO agendaDTO)
        {
            Agenda agenda = new Agenda
            {
                Id_Agenda = agendaDTO.Id_Agenda,
                Titulo = agendaDTO.Titulo,
                Descricao = agendaDTO.Descricao,
                Observacoes = agendaDTO.Observacoes,
                Detalhes = agendaDTO.Detalhes,
                flagExibir = agendaDTO.flagExibir

            };


            _context.Add(agenda);
            _context.SaveChanges();
            return agendaDTO;
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IList<AgendaDTO> ConsultarDadosAgenda(int idIntervencao, string Descricao)
        {
            IList<AgendaDTO> agendaDTO = new List<AgendaDTO>();
            var result = _context.Agenda.AsQueryable().Where(e => e.Id_Agenda == idIntervencao).ToList();
          

            foreach(var item in result)
            {
                foreach(var agendaItem in agendaDTO)
                {
                    agendaItem.Id_Agenda = item.Id_Agenda;
                    agendaItem.Titulo = item.Titulo;
                    agendaItem.Descricao = item.Descricao;
                    agendaItem.Detalhes = item.Detalhes;
                    agendaItem.flagExibir = item.Detalhes;
                    agendaItem.Observacoes = item.Observacoes;
                }

            }
            return agendaDTO;
        }
    }
}
