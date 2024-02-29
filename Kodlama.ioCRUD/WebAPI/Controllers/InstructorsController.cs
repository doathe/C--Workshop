using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InstructorsController : ControllerBase
{
    private readonly IInstructorService _instructorService;

    public InstructorsController(IInstructorService instructorService)
    {
        _instructorService = instructorService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_instructorService.GetAll());
    }
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_instructorService.Get(id));
    }
    [HttpPost]
    public IActionResult Add(Instructor instructor)
    {
        _instructorService.Add(instructor);
        return Ok();
    }
    [HttpPut]
    public IActionResult Update(Instructor instructor)
    {
        _instructorService.Update(instructor);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _instructorService.Delete(id);
        return Ok();
    }
}
