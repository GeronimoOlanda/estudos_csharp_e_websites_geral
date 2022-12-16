using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GeroOlanda.Domain.Entities.Util
{
    public class Utils
    {
        private  RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

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
