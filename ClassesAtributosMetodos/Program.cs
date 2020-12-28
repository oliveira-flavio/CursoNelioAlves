using System;
using System.Globalization;

//Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
//válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
//possui a maior área.
//A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
//seguinte (fórmula de Heron): area = p(p - a)(p - b)(p - c) onde p = (a+b+c) /2 

namespace ClassesAtributosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            // Entrada de dados no console e atribuição de valores nas variáveis

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area(); //chamada do método de cálculo de área feito na classe Triangulo

            double areay = y.Area();

            Console.WriteLine($"Área de X= {areax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y= {areay.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areax > areay)
            {
                Console.WriteLine("Maior área é de X");
            }
            else
            {
                Console.WriteLine("Maior área é de Y");
            }

        }
    }
}
