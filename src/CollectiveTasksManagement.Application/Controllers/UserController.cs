using CollectiveTasksManagement.Domain.Commands;
using Microsoft.AspNetCore.Mvc;

namespace CollectiveTasksManagement.Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Hello World");
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateUserCommand command)
    {
        return Ok(command);
    }
}
