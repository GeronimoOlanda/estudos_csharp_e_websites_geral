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
    public class InformacoesRepository : IInformacoesRepository
    {
        protected GeroOlandaDbContext _context;

        public InformacoesRepository(GeroOlandaDbContext context)
        {
            _context = context;
        }
        public InformacoesRepository()
        {
            // inicialização do constructor vazio.
        }
        public InformacoesDTO CadastrarInformacoes(InformacoesDTO informacoesDTO)
        {
            //implementacao do metodo que vai cadastrar as informações na base.
            throw new NotImplementedException();
        }
    }
}
