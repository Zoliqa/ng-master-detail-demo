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

        [HttpGet("[action]")]
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

        [HttpGet("[action]")]
        public Article GetArticle(int id)
        {
            var article = _context.Articles.SingleOrDefault(a => a.Id == id);

            return article;
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]Article a)
        {
            try
            {
                _context.Attach(a);

                _context.Articles.Remove(a);

                _context.SaveChanges();

                return Ok(a.Id);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult Update([FromBody]Article a)
        {
            try
            {
                _context.Attach(a);

                _context.Articles.Update(a);

                _context.SaveChanges();

                return Ok(a);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        public class ListArticles
        {
            public List<Article> Articles { get; set; }
            public int NumberOfPages { get; set; }
        }
    }
}
