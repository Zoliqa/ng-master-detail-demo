using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterDetailApp.EF
{
    public class MasterDetailContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }

        public MasterDetailContext(DbContextOptions<MasterDetailContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Category1",
                CreatedDateTime = DateTime.Now
            },
            new Category
            {
                Id = 2,
                Name = "Category2",
                CreatedDateTime = DateTime.Now
            });

            var articles = Enumerable.Range(1, 100).Select(x => new Article
            {
                Id = x,
                Title = "Title" + x,
                Description = "Description" + x,
                CategoryId = new Random().Next(2) + 1,
                CreatedDateTime = DateTime.Now.AddDays(-x),
            });

            modelBuilder.Entity<Article>().HasData(articles);
        }
    }

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public Category Category { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public List<Article> Articles { get; set; }
    }
}
