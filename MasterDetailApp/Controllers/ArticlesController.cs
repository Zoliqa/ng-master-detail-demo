using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterDetailApp.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MasterDetailApp.Controllers
{
    [Route("api/[controller]")]
    public class ArticlesController : Controller
    {
        public const int PageSize = 5;
        private MasterDetailContext _context;
        private readonly ILogger _logger;

        public ArticlesController(MasterDetailContext context, ILogger<ArticlesController> logger)
        {
            _context = context;

            _logger = logger;
        }

        [HttpGet]
        public ListArticles List(int pageNumber, string searchTerm)
        {
            var from = (pageNumber - 1) * PageSize;

            var articles =
                _context.Articles
                    .Where(a =>
                        string.IsNullOrWhiteSpace(searchTerm) ||
                        a.Title.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) ||
                        a.Description.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase));

            var pagedArticles = 
                articles
                    .OrderBy(x => x.Id)
                    .Skip((pageNumber - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();


            var result = new ListArticles
            {
                Articles = pagedArticles,
                NumberOfPages = (int)Math.Ceiling((double)articles.Count() / PageSize),
            };

            return result;
        }

        [HttpDelete]
        public void Delete([FromBody]int id)
        {
            _logger.LogDebug("id " + id);

            var article = _context.Articles.Find(id);

            if (article != null)
            {
                _context.Articles.Remove(article);

                _context.SaveChanges();

                //return Ok(id);
            }

            //return NotFound(id);
        }

        public class ListArticles
        {
            public List<Article> Articles { get; set; }
            public int NumberOfPages { get; set; }
        }
    }
}
