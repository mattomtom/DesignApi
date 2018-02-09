using System.Threading.Tasks;
using Design.Infrastructure.Commands;
using Design.Infrastructure.Commands.Walkers;
using Microsoft.AspNetCore.Mvc;

namespace Design.Api.Controllers
{
    public class WalkerController : ApiControllerBase
    {
        public WalkerController(ICommandDispatcher commandDispatcher) : base(commandDispatcher)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateWalker command) 
        {
            await CommandDispatcher.DispatchAsync(command);

            return NoContent();
        }
    }
}