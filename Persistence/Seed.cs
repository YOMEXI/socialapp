using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
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
                    Title = "Containerization today",
                    CreatedAt = DateTime.Now.AddMonths(-2),
                    Description = "Docker Really Has no competition",
                    Category = "DevOps",

                },
                  new Post
                {
                    Title = ".Net 6 is cool",
                    CreatedAt = DateTime.Now.AddMonths(-1),
                    Description = "Microsoft has made .Net 6 easy for beginners with improvements such as minimal api",
                    Category = "Web-Frameworks",

                },

                     new Post
                {
                    Title = "is Nodejs the new king",
                    CreatedAt = DateTime.Now.AddMonths(1),
                    Description = "Nestjs is really really cool",
                    Category = "Web-Frameworks",
                },


            };

            await context.Posts.AddRangeAsync(posts);
            await context.SaveChangesAsync();
        }
    }
}