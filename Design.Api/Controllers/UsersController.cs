using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Design.Infrastructure.DTO;
using Design.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Design.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET 
        [HttpGet("{email}")]
        public UserDto Get(string email)
            => _userService.Get(email);
    }
}