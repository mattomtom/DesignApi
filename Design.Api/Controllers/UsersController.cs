using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Design.Infrastructure.Commands;
using Design.Infrastructure.Commands.Users;
using Design.Infrastructure.DTO;
using Design.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Design.Api.Controllers
{
    public class UsersController : ApiControllerBase
    {
        private readonly IUserService _userService;

        
        public UsersController(IUserService userService,
             ICommandDispatcher commandDispatcher) : base(commandDispatcher)
        {
            _userService = userService;
        }

        // GET 
        [HttpGet("{email}")]
        public async Task<IActionResult> Get(string email)
        {
            var user = await _userService.GetAsync(email);
            if(user == null)
            {
                return NotFound();
            }

            return Json(user);
        }
        // POST
        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]CreateUser command) 
        {
            await CommandDispatcher.DispatchAsync(command);

            return Created($"users/{command.Email}", new object());
        }
    }
}
