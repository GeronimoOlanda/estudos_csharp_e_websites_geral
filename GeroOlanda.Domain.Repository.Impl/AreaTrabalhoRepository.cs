using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Repository.Impl.GeroDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Repository.Impl
{
    public class AreaTrabalhoRepository : IAreaTrabalhoRepository
    {
        protected GeroOlandaDbContext _context;

        public AreaTrabalhoRepository(GeroOlandaDbContext context)
        {
            _context = context;
        }
        public AreaTrabalhoRepository()
        {

        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public AreaTrabalhoDTO AreaTrabalhoDetalhes(AreaTrabalhoDTO AreaTrabalho)
        {
            AreaTrabalho areaTrabalho = new AreaTrabalho()
            {
              Width= AreaTrabalho.Width,
              Height= AreaTrabalho.Height,
              Name= AreaTrabalho.Name,
              Type= AreaTrabalho.Type,
              Background= AreaTrabalho.Background,
              Description= AreaTrabalho.Description,
              ImageUrl= AreaTrabalho.ImageUrl,
               
            };
            _context.Add(areaTrabalho);
            _context.SaveChanges();

            return AreaTrabalho;
        }
    }
}
