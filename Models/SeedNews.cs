using Microsoft.EntityFrameworkCore;
using LeTangHuyTuanKiet.Models;
namespace LeTangHuyTuanKiet.Models
{
    public static class SeedNews
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.News == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.News.Any())
                {
                    return;   // DB has been seeded
                }

                context.News.AddRange(
                    new News
                    {
                    
                    Title = " Title 1",
                    ImageUrl = " the first",
                    Content = " 1234",
                    Author = " Me"
                    },

                    new News
                    {
                   
                    Title = " Title 2",
                    ImageUrl = " data...",
                    Content = " 10 diem",
                    Author = " Me"
                    },

                    new News
                    {
                      
                    Title = " News Title 3",
                    ImageUrl = " the second",
                    Content = " hot News",
                    Author = " 123"
                    },

                   new News
                    {
                    Title = " News Title44",
                    ImageUrl = " the third",
                    Content = " 3245",
                    Author = " 13134"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}