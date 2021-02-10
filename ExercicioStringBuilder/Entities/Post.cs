using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioStringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        // Relação de 1 para muitos (1 post tem muitos comentários)
        // Já faz o instanciamento da lista para receber os comentários

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        // Utilizando o método StringBuilder para montar o ToString 
        // de maneira mais eficiente

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append("Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }




        // Quando temos uma relação de composição de 1 para muitos,
        // são adicionados como padrão métodos (add remove) de adicionar e remover,
        // neste caso, comentários.

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        //    ^       ^       ^
       // variável | metodo | parâmetro de entrada
            // Irá adicionar o comentário recebido como parâmetro de entrada (comment)
            // na lista de comentários List<Comment>
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
         //    ^       ^       ^
        // variavel | metodo | parâmetro de entrada
        }

    }
}
