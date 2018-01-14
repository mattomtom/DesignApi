using System.Threading.Tasks;

namespace Design.Infrastructure.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}