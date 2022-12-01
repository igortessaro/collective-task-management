using CollectiveTasksManagement.Domain.Commands;
using Microsoft.AspNetCore.Mvc;

namespace CollectiveTasksManagement.Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class TargetGoalsController : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] CreateTargetGoalsCommand command)
    {
        return Ok(command);
    }
}
