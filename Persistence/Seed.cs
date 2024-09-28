using System.Diagnostics;

namespace DotnetBackend.Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Posts.Any()) return;

            var posts = new List<Post>
            {
                new Post
                {
                    Title = "Title 1",
                    Body = "Body",
                    Tag = "Tag",
                    CreatedDate = DateTime.UtcNow.AddMonths(-2),
                },
                new Post
                {
                    Title = "Title 2",
                    Body = "Body",
                    Tag = "Tag",
                    CreatedDate = DateTime.UtcNow.AddMonths(-2),
                },
                new Post
                {
                    Title = "Title 3",
                    Body = "Body",
                    Tag = "Tag",
                    CreatedDate = DateTime.UtcNow.AddMonths(-2),
                },
                new Post
                {
                    Title = "Title 4",
                    Body = "Body",
                    Tag = "Tag",
                    CreatedDate = DateTime.UtcNow.AddMonths(-2),
                },
                new Post
                {
                    Title = "Title 5",
                    Body = "Body",
                    Tag = "Tag",
                    CreatedDate = DateTime.UtcNow.AddMonths(-2),
                },
            };

            await context.Posts.AddRangeAsync(posts);
            await context.SaveChangesAsync();
        }

    }
}
