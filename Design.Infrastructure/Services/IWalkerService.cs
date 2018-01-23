using System;
using System.Threading.Tasks;
using Design.Infrastructure.DTO;

namespace Design.Infrastructure.Services
{
    public interface IWalkerService : IService
    {
        Task<WalkerDto> GetAsync(Guid userId);
    }
}