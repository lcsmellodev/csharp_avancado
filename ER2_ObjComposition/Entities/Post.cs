

using System.Net.Http.Headers;
using System.Reflection;

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
            string comments = "";
            foreach(Comment item in Comments)
            {
                comments+= item+"\n";
            }
            return $"{Title}\n{Likes} Likes - {Date}\nComments:\n{comments}";
        }
    }
}
