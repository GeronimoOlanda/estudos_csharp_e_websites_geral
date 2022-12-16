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
    public class LoginUserRepository : ILoginUserRepository
    {
        protected GeroOlandaDbContext _context;

        public LoginUserRepository(GeroOlandaDbContext context)
        {
            _context = context;
        }
        public LoginUserRepository()
        {

        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public UserLogin CadastrarDadosLogin(UserLogin userLogin)
        {   
            _context.Add(userLogin);
            _context.SaveChanges();

            return userLogin;
        }
    }
}
