using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;
using AprendeNetCore2.Services.Contracts;

namespace AprendeNetCore2.Controllers
{

    public class UserData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    [Route("api/[controller]")]
    public class AuthController : Controller
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("token")]
        public IActionResult Token([FromBody]UserData data)
        {

            if (_authService.ValidateLogin(data.UserName, data.Password)){
                var date = DateTime.UtcNow;
                var expireDate = TimeSpan.FromHours(5);
                var expireDateTime = date.Add(expireDate);

                var token = _authService.GenerateToken(date, data.UserName, expireDate);

                return Ok(new
                {
                    Token = token,
                    ExpireAt = expireDateTime
                });
                
            }
            else
            {
                return StatusCode(401);
            }

        }


    }
}
