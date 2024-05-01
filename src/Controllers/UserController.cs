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
    public User? UpdateOne(string email ,[FromBody] User user)
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
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public ActionResult<User> CreateOne([FromBody] User user)
    {
        if(user is not null)
        {
          var createdUser =  _userService.CreateOne(user);
          return CreatedAtAction(nameof(CreateOne), createdUser);
        }
        return BadRequest();
      
    }
}