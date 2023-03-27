using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.CategoryServices;

namespace OnionArchitecture2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService=categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
          return Ok( await _categoryService.GetAllCategory());
        }
    }
}
