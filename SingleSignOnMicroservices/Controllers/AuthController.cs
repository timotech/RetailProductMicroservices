using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SingleSignOnMicroservices.Domain.Models;
using SingleSignOnMicroservices.Services;

namespace SingleSignOnMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        //api/auth/login
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginBindingModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginUserAsync(model);

                if (result.IsSuccess)
                    return Ok(result);

                return BadRequest(result);
            }

            return BadRequest("Please ensure to correctly fill the form");
        }
    }
}
