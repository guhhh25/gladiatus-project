using Microsoft.AspNetCore.Mvc;

using Gladiatus.Application.Interface;
using Gladiatus.Core.Entities;
using Gladiatus.Application.Dtos;
using AutoMapper;
using Gladiatus.Common;

namespace Gladiatus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserApiService _userAppService;

        public UserController(IUserApiService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto user)
        {
            var result = await _userAppService.CreateUser(user);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
    }
}