using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MasterDetailApp.EF.Concrete;
using MasterDetailApp.EF.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MasterDetailApp.Controllers
{
    [Route("api/[controller]")]
    public class ArticleController : Controller
    {
        public const int PageSize = 5;
        private IMasterDetailUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public ArticleController(IMasterDetailUnitOfWork unitOfWork, ILogger<ArticleController> logger)
        {
            _unitOfWork = unitOfWork;

            _logger = logger;
        }

        [HttpGet("[action]")]
        public async Task<ListArticles> List(int pageNumber, string searchTerm)
        {
            var from = (pageNumber - 1) * PageSize;

            Expression<Func<Article, bool>> where = a =>
                string.IsNullOrWhiteSpace(searchTerm) ||
                a.Title.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) ||
                a.Description.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase);

            var articlesPaged =
                await _unitOfWork.ArticleRepository
                    .GetAllAsync(where,
                        articles => articles.OrderBy(a => a.Id),
                        from,
                        PageSize);

            var articlesCount = await _unitOfWork.ArticleRepository.CountAsync(where);

            var result = new ListArticles
            {
                Articles = articlesPaged,
                NumberOfPages = (int)Math.Ceiling((double)articlesCount / PageSize),
            };

            return result;
        }

        [HttpGet("[action]")]
        public Article GetArticle(int id)
        {
            var article = _unitOfWork.ArticleRepository.GetById(id);

            return article;
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]Article a)
        {
            try
            {
                _unitOfWork.ArticleRepository.Remove(a);

                _unitOfWork.SaveChanges();

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
                _unitOfWork.ArticleRepository.Update(a);

                _unitOfWork.SaveChanges();

                return Ok(a);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public IActionResult Insert([FromBody]Article a)
        {
            try
            {
                a.CreatedDateTime = DateTime.Now;

                _unitOfWork.ArticleRepository.Add(a);

                _unitOfWork.SaveChanges();

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
