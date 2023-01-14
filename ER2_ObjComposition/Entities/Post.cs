

using System.Net.Http.Headers;
using System.Reflection;
using System.Text;

namespace ER2_ObjComposition.Entities
{
    internal class Post
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }
        public Post(DateTime Date, string Title, string Content, int Likes)
        {
            this.Date = Date;
            this.Title = Title;
            this.Content = Content;
            this.Likes = Likes;
        }

        public override string ToString()
        {
            //string comments = "";
            //foreach(Comment item in Comments)
            //{
            //    comments+= item+"\n";
            //}
            //return $"{Title}\n{Likes} Likes - {Date}\nComments:\n{comments}";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Title);
            sb.Append(this.Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Comments:");

            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
            
        }
    }
}
