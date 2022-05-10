using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstoque
{
    internal class Produto
    {
        public string NomeProduto;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            NomeProduto = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return NomeProduto + "\t\nR$ " + Preco.ToString("F2") + "\t\n" + Quantidade + " unidades\t\nTotal: R$ " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
