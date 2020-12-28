using System;
using System.Globalization;

//EXERCÍCIO 02:
//Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
//médio dos funcionários.

namespace ExercicioClasses02
{
    class Program
    {
        static void Main(string[] args)
        {            

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Digite o nome do 1º Funcionário: ");
            funcionario1.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do 1º Funcionário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do 2º Funcionário: ");
            funcionario2.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do 2º Funcionário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.WriteLine("A média dos saláros é {0:c}", media);
        }
    }
}
