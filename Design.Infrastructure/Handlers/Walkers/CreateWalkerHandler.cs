using System.Threading.Tasks;
using Design.Infrastructure.Commands;
using Design.Infrastructure.Commands.Walkers;
using Design.Infrastructure.Services;

namespace Design.Infrastructure.Handlers.Walkers
{
    public class CreateWalkerHandler : ICommandHandler<CreateWalker>
    {
        private readonly IWalkerService _walkerService;

        public CreateWalkerHandler(IWalkerService walkerService)
        {
            _walkerService = walkerService;
        }
        public async Task HandleAsync(CreateWalker command)
        {
            //TODO: Walker logic
            await Task.CompletedTask;
        }
    }
}