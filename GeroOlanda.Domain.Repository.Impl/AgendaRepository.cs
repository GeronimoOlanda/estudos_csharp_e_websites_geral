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
            throw new NotImplementedException();
        }

        public IList<AgendaDTO> ConsultarDadosAgenda(AgendaDTO consultarAgenda)
        {
            throw new NotImplementedException();
        }
    }
}
