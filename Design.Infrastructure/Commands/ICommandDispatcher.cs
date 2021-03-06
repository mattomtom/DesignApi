using System.Threading.Tasks;

namespace Design.Infrastructure.Commands
{
    public interface ICommandDispatcher
    {
         Task DispatchAsync<T>(T command) where T : ICommand;
    }
}