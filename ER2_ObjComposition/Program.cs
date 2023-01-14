using ER2_ObjComposition.Entities;

List<Post> posts = new List<Post>();

posts.Add(new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12));
posts[0].Comments.Add(new Comment("Have a nice trip"));
posts[0].Comments.Add(new Comment("Wow that's awesome!"));
posts.Add(new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5));
posts[1].Comments.Add(new Comment("Good night"));
posts[1].Comments.Add(new Comment("May the Force be with you"));

foreach(Post p in posts)
{
    Console.WriteLine(p);
}
