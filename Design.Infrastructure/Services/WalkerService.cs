using System;
using Design.Core.Repositories;
using Design.Infrastructure.DTO;

namespace Design.Infrastructure.Services
{
    public class WalkerService : IWalkerService
    {
        private readonly IWalkerRepository _walkerRepository;

        public WalkerService(IWalkerRepository walkerRepository)
        {
            _walkerRepository = walkerRepository;
        }

        public WalkerDto Get(Guid userId)
        {
            var walker = _walkerRepository.Get(userId);

            return new WalkerDto
            {
                //TODO
            };
        }
    }
}