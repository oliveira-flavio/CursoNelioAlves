using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            //Add adiciona o item ao final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            //Insert tem a opção de sugerir em que possição o item será inserido
            list.Insert(2,"Marcos");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Número de ítens na lista {list.Count}");

            string s1 = list.Find(x => x[0] == 'A'); /* Expressão Lambda (leitura): Buscas o objeto x talque(=>) x na posição [0] seja igual ao caracter A maiúsculo*/
            Console.WriteLine($"Primeiro nome começando com A {s1}");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Último nome começando com A {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Indice do PRIMEIRO nome começando com A {pos1} ");

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Indice do ULTIMO nome começando com A {pos2} ");

            List<string> list2 = list.FindAll(x => x.Length >= 5);
            Console.WriteLine("-------------------------");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            list.Remove("Alex");
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAll(x => x[0] =='M');
            Console.WriteLine("-------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(2);
        }
    }
}
