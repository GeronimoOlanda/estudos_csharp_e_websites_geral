using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Fundamentos
{
    public class Fundamentos
    {
        // exibe a media dos valores
        public double CalculoMedia(double valor1, double valor2)
        {
            double media = ((valor1 + valor2) / 2);

            return media;
        }

        //retorna a mensagem
        public string Mensagem(string mensagem)
        {
            return mensagem;
        }

        public string MensagemErro(string erro)
        {
            return  erro;
        }

       
    }
}
