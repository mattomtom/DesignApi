using System;
using Design.Infrastructure.DTO;

namespace Design.Infrastructure.Services
{
    public interface IWalkerService
    {
        WalkerDto Get(Guid userId);
    }
}