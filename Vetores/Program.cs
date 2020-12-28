using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[1];
            }

            double avg = sum / n;

            Console.WriteLine($"Average Height: {avg.ToString("F2")}");
        }
    }
}
