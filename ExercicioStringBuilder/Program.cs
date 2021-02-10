using System;
using ExercicioStringBuilder.Entities;

namespace ExercicioStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Traz muamba!");
            Comment c2 = new Comment("Compra vinho!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2020 13:05:44"),
                "Viajando pro Paraguai!",
                "Vou trazer umas muambas, quem tá afim?",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Compre um AzBox");
            Comment c4 = new Comment("Vai na feirinha da Argentina");

            Post p2 = new Post(
                DateTime.Parse("02/02/2021 14:20:31"),
                "Já estou aqui no Paraguai!",
                "Enviem dicas de onde comer no Paraguai",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
