using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_categoryService.GetAll());
    }
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_categoryService.Get(id));
    }
    [HttpPost]
    public IActionResult Add(Category category)
    {
        _categoryService.Add(category);
        return Ok();
    }
    [HttpPut]
    public IActionResult Update(Category category)
    {
        _categoryService.Update(category);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _categoryService.Delete(id);
        return Ok();
    }
}
