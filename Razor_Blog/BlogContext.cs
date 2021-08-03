﻿using Microsoft.EntityFrameworkCore;
using Razor_Blog.Mapping;
using Razor_Blog.Model;

namespace Razor_Blog
{
    public class BlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
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
