using System;

namespace ExercicioClasses01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome da 1ª pessoa: ");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da 2ª pessoa: ");
            pessoa2.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da 2ª pessoa: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"{pessoa1.Nome} tem mais idade");
            }
            else
            {
                Console.WriteLine($"{pessoa2.Nome} tem mais idade");
            }

        }
    }
}
