using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Models
{
    public class ProdutoModel
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public ProdutoModel(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        /// <summary>
        /// sobrecarga de metodo
        /// </summary>
        /// <returns></returns>
       public ProdutoModel(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = 0;
        }
        public double ValotTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = quantidade;
        }
    }
}
