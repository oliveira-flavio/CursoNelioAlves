using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.Write("Quantos números você vai digitar? ");
            int n1 = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n1; i++)
            {
                Console.Write($"Valor {i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine($"Soma é igual a {soma}");

        }
       
        
    }
}
