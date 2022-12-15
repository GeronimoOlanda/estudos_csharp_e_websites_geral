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
    public class HomeRepository : IHomeRepository
    {
        protected GeroOlandaDbContext _context;

        public HomeRepository(GeroOlandaDbContext context)
        {
            _context = context;
        }
        public HomeRepository()
        {

        }

        public Task<IList<Home>> Cadastrar(string Descricao)
        {
            throw new NotImplementedException();
        }

        public string CadastrarUma(string descricao)
        {
            Home home = new Home
            {
                Descricao = descricao
            };


            _context.Add(home);
            _context.SaveChanges();
            return home.Descricao;
        }

        public Task<IList<HomeDTO>> ConsultarDadosPorIdUsuario(decimal IdUsuario)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public ContatosDto GetDadosContato(string Id, string telefone)
        {
            throw new NotImplementedException();
        }
    }
}
