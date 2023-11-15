using AB12.Application.Users.Commands;
using AB12.Services.Components;
using Microsoft.AspNetCore.Mvc;

namespace AB12.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
  private readonly ILogger<UserController> _logger;
  private readonly UserService _service;
  public UserController(
    ILogger<UserController> logger,
    UserService service
    )
  {
    _logger = logger;
    _service = service;
  }

  [HttpPost()]
  public async Task<IActionResult> Create([FromForm] CreateUserCommand command)
  {
    try
    {
      var result = await _service.CreateAsync(command);
      return Ok(result);
    }
    catch (Exception ex)
    {
      _logger.LogError("Error creating user");
      throw ex;
    }
  }

}