using System;
using System.Threading.Tasks;
using Design.Infrastructure.DTO;

namespace Design.Infrastructure.Services
{
    public interface IWalkerService
    {
        Task<WalkerDto> GetAsync(Guid userId);
    }
}