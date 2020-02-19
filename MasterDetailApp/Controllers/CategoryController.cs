using System.Collections.Generic;
using System.Linq;
using MasterDetailApp.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
    }
}
