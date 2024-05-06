using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers;

public class UserController : BaseController
{
    private IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPatch("{email}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public UserReadDto? UpdateOne(string email, [FromBody] UserReadDto user)
    {
        return _userService.UpdateOne(email, user);
    }

    [HttpGet]
    public List<UserReadDto> FindAll()
    {
        return _userService.FindAll();
    }

    [HttpGet("{email}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<UserReadDto?> FindOne(string email)
    {
        return Ok(_userService.FindOneByEmail(email));
    }

    [HttpPost("signup")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public ActionResult<UserReadDto> SignUp([FromBody] UserCreateDto user)
    {
        if (user is not null)
        {
            var createdUser = _userService.SignUp(user);
            return CreatedAtAction(nameof(SignUp), createdUser);
        }
        return BadRequest();

    }

    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public ActionResult<UserReadDto> SignIn([FromBody] UserSignIn user)
    {
        if (user is not null)
        {
            UserReadDto? userRead = _userService.SignIn(user);
            if(userRead is null)
            {
              return BadRequest();
            }
            return Ok(userRead);
        }
        return BadRequest();

    }
}