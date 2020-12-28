using System;

//Fazer um programa para ler os dados de um produto em estoque (nome, preço e
//quantidade no estoque). Em seguida:
//• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no
//estoque)
//• Realizar uma entrada no estoque e mostrar novamente os dados do produto
//• Realizar uma saída no estoque e mostrar novamente os dados do produto

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();


            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Dados do produto: {produto}");
            Console.WriteLine();

            //• Realizar uma entrada no estoque e mostrar novamente os dados do produto
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtde);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Estoque atualizado: {produto}");

            Console.WriteLine();

            //• Realizar uma saída no estoque e mostrar novamente os dados do produto
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtde);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Estoque atualizado: {produto}");


        }
    }
}
