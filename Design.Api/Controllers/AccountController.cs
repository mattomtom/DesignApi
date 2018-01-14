using System.Threading.Tasks;
using Design.Infrastructure.Commands;
using Design.Infrastructure.Commands.Users;
using Design.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Design.Api.Controllers
{
    public class AccountController : ApiControllerBase
    {
        public AccountController(ICommandDispatcher commandDispatcher) : base(commandDispatcher)
        {
            
        }

        [HttpPut]
        [Route("password")]
        public async Task<IActionResult> Put([FromBody]ChangeUserPassword command) 
        {
            await CommandDispatcher.DispatchAsync(command);

            return NoContent();
        }
    }
}