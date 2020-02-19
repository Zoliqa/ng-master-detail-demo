using MasterDetailApp.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterDetailApp.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private MasterDetailContext _context;
        private readonly ILogger _logger;

        public CategoryController(MasterDetailContext context, ILogger<CategoryController> logger)
        {
            _context = context;

            _logger = logger;
        }

        [HttpGet("[action]")]
        public List<Category> List()
        {
            return _context.Categories.ToList();
        }

        [HttpGet("[action]")]
        public Category GetCategory(int id)
        {
            var category = _context.Categories.SingleOrDefault(c => c.Id == id);

            return category;
        }


        [HttpPost]
        public IActionResult Update([FromBody]Category c)
        {
            try
            {
                _context.Attach(c);

                _context.Categories.Update(c);

                _context.SaveChanges();

                return Ok(c);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public IActionResult Insert([FromBody]Category c)
        {
            try
            {
                c.CreatedDateTime = DateTime.Now;

                _context.Categories.Add(c);

                _context.SaveChanges();

                return Ok(c);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Category c)
        {
            try
            {
                _context.Attach(c);

                _context.Categories.Remove(c);

                _context.SaveChanges();

                return Ok(c.Id);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
