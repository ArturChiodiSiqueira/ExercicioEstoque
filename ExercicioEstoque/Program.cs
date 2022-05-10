using System;

namespace ExercicioEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ABAIXO, ENTRE COM OS DADOS DO PRODUTO:\n");
            Console.Write("Nome: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto product = new Produto(nomeProduto, preco, quantidade);

            Console.Clear();
            Console.WriteLine("Dados do produto: " + product + "\n\n");

            Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
            int quantidadeAcrecida = int.Parse(Console.ReadLine());
            product.AdicionarProdutos(quantidadeAcrecida);

            Console.WriteLine("\nDados atualizados: " + product);

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            product.RemoverProdutos(quantidadeRemovida);

            Console.WriteLine("\nDados atualizados: " + product);

            Console.WriteLine("\n\n PROGRAMA ENCERRADO, PARA SAIR APERTE QUALQUER TECLA!");
            Console.ReadKey();
        }
    }
}
