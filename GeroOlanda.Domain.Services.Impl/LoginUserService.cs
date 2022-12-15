using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Repository;
using GeroOlanda.Domain.Services;

namespace GeroOlanda.Domain.Services.Impl
{
    public class LoginUserService : ILoginUserService
    {
        private readonly ILoginUserRepository _loginUserRepository;
        public LoginUserService()
        {

        }
        public LoginUserService(ILoginUserRepository loginUserRepository)
        {
            _loginUserRepository = loginUserRepository;
        }
        public UserLogin CadastrarDadosLogin(UserLogin userLogin)
        {
           var dadosLogin = _loginUserRepository.CadastrarDadosLogin(userLogin);

            return dadosLogin;
        }
    }
}