using Microsoft.EntityFrameworkCore;
using Razor_Blog.Mapping;

namespace Razor_Blog
{
    public class BlogContext : DbContext
    {
        public BlogContext( DbContextOptions<BlogContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
