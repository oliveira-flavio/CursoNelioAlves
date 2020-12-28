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

            Console.WriteLine("Entre os dados do produto: ");    // <--- Entrada dos dados no console
            Console.Write("Nome: ");                            
            string nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());  // <--- Finalização de entrada e leitura de dados 
            // ^ -- Variável auxiliar 


            
            Produto produto = new Produto(nome, preco, quantidade); // <--- Instanciando um novo objeto já com as características informadas pelo usuário 
                                                                    // e exigidas pelo construtor da classe produto (nome, preço, quantidade).

            Produto produto1 = new Produto(nome, preco); // Construtor com sobrecarga. Sobrecarga ajuda a criar um objeto escolhendo os atributos iniciais.
            
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
