using System;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {            

            Console.WriteLine("Entre com o valor do Raio");
            double raio = double.Parse(Console.ReadLine());
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString()}");
            Console.WriteLine($"Volume: {volume.ToString()}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString()}");
        }

    }

}
