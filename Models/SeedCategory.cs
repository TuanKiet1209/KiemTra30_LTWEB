using Microsoft.EntityFrameworkCore;
using LeTangHuyTuanKiet.Models;

namespace LeTangHuyTuanKiet.Models
{
    public static class SeedCategory
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Category == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new Category
                    {
                      Name="TIN MOI NHAT"  
                    },

                    new Category
                    {
                        Name="TIN MOI NHAT" 
                    },

                    new Category
                    {
                         Name="TIN TUC TRONG NGAY" 
                    },

                    new Category
                    {
                          Name="TIN NONG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}