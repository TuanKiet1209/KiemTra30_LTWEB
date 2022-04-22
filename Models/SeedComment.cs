using Microsoft.EntityFrameworkCore;
using LeTangHuyTuanKiet.Models;

namespace LeTangHuyTuanKiet.Models
{
    public static class SeedComment
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Comment == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Comment.Any())
                {
                    return;   // DB has been seeded
                }

                context.Comment.AddRange(
                    new Comment
                    {
                        
                     Content ="The Shopp",
                     Author =" TK",
                     CreatedAt = " Decepticon"
                     
                    },

                    new Comment
                    { 
                    Author =" The Band",
                    Content ="365 Dabald",
                    CreatedAt = "123"                    
                    },

                    new Comment
                    {
                        Content ="The SuperMan",
                     Author =" Juane",
                     CreatedAt = " Haha"
                     
                    },

                   new Comment
                    {
                     Content ="The Revenger",
                     Author =" Spider man",
                     CreatedAt = " goddd"
                    
                    }
                );
                context.SaveChanges();
            }
        }
    }
}