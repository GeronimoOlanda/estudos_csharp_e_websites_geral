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

        public UserLogin ConsultarCadastroPorId(int id)
        {
            var result = _context.UserLogin.AsQueryable().Where(e => e.Id_Usuario == id).ToList();
            UserLogin userLogin = new UserLogin();
            foreach(var item in result)
            {
                userLogin.Id_Usuario = item.Id_Usuario;

                userLogin.LoginUser = item.LoginUser;
                userLogin.UserName = item.UserName;

                userLogin.Password_Encrypt = item.Password_Encrypt;
                userLogin.Password = item.Password;

                userLogin.flag_Setor = item.flag_Setor;
                userLogin.flag_UserAlive = item.flag_UserAlive;

                userLogin.Created_At = item.Created_At;
                userLogin.Updated_At = item.Updated_At;


            }
          
            return userLogin;
        }
    }
}
