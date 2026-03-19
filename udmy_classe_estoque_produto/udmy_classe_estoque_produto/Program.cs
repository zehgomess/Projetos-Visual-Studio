using System;
using udemy_produto;
using System.Globalization;

// Criação de classe estoque de produtos

namespace udemy_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Produto p = new Produto{p.GetNome,p.GetPreco,p.GetQuantidade};

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " +p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque:");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
           
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}