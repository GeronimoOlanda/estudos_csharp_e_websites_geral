using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Entities.Dtos;
using GeroOlanda.Domain.Entities.Util;
using GeroOlanda.Domain.Repository;
using GeroOlanda.Domain.Services;
using System.Security.Cryptography;

namespace GeroOlanda.Domain.Services.Impl
{
    public class LoginUserService : ILoginUserService
    {
        private readonly ILoginUserRepository _loginUserRepository;
        private RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        public LoginUserService()
        {

        }
        public LoginUserService(ILoginUserRepository loginUserRepository)
        {
            _loginUserRepository = loginUserRepository;
            
        }
        public UserLogin CadastrarDadosLogin(UserLogin userLogin)
        {
            

            userLogin.Created_At = DateTime.Now;
            userLogin.Updated_At = DateTime.Now;
            userLogin.Password_Encrypt = GerarHashSenha(userLogin.Password);

            var dadosLogin = _loginUserRepository.CadastrarDadosLogin(userLogin);

            return dadosLogin;
        }

        

        public string PegaSenha(string senha)
        {
            var senhaHash = GerarHashSenha(senha);

            return senhaHash;
        }
        public string GerarHashSenha(string password)
        {
            byte[] salt = new byte[16];
            rngCsp.GetBytes(salt);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt);

            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string hashSenha = Convert.ToBase64String(hashBytes);

            return hashSenha;
        }
    }
}