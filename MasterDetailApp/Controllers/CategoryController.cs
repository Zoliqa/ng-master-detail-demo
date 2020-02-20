using MasterDetailApp.EF.Concrete;
using MasterDetailApp.EF.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace MasterDetailApp.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private IMasterDetailUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public CategoryController(IMasterDetailUnitOfWork unitOfWork, ILogger<CategoryController> logger)
        {
            _unitOfWork = unitOfWork;

            _logger = logger;
        }

        [HttpGet("[action]")]
        public List<Category> List()
        {
            return _unitOfWork.CategoryRepository.GetAll();
        }

        [HttpGet("[action]")]
        public Category GetCategory(int id)
        {
            var category = _unitOfWork.CategoryRepository.GetById(id);

            return category;
        }


        [HttpPost]
        public IActionResult Update([FromBody]Category c)
        {
            try
            {
                _unitOfWork.CategoryRepository.Update(c);

                _unitOfWork.SaveChanges();

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

                _unitOfWork.CategoryRepository.Add(c);

                _unitOfWork.SaveChanges();

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
                _unitOfWork.CategoryRepository.Remove(c);

                _unitOfWork.SaveChanges();

                return Ok(c.Id);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
