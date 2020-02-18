using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MasterDetailApp.Controllers
{
    [Route("api/[controller]")]
    public class ArticlesController : Controller
    {
        public const int PageSize = 5;

        [HttpGet]
        public ListArticles List(int pageNumber, string searchTerm)
        {
            var from = (pageNumber - 1) * PageSize;

            var articles = Enumerable.Range(from + 1, 5).Select(i => new Article
            {
                Id = i,
                Title = "Title" + i,
                Description = "Description" + i,
                CategoryId = i,
                CreatedDateTime = DateTime.Now.AddDays(-i * 10),
            });

            var result = new ListArticles
            {
                Articles = articles.ToArray(),
                NumberOfPages = 10,
            };

            return result;
        }

        [HttpDelete]
        public void Delete(int id)
        {
        }

        public class Article
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public int CategoryId { get; set; }
            public DateTime CreatedDateTime { get; set; }
        }

        public class ListArticles
        {
            public Article[] Articles { get; set; }
            public int NumberOfPages { get; set; }
        }
    }
}
