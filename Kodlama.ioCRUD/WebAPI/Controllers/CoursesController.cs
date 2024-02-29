using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    private readonly ICourseService _courseService;

    public CoursesController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_courseService.GetAll());
    }
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_courseService.Get(id));
    }
    [HttpPost]
    public IActionResult Add(Course course)
    {
        _courseService.Add(course);
        return Ok();
    }
    [HttpPut]
    public IActionResult Update(Course course)
    {
        _courseService.Update(course);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _courseService.Delete(id);
        return Ok();
    }
}
