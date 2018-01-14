using System;
using System.Threading.Tasks;
using AutoMapper;
using Design.Core.Domain;
using Design.Core.Repositories;
using Design.Infrastructure.DTO;

namespace Design.Infrastructure.Services
{
    public class WalkerService : IWalkerService
    {
        private readonly IWalkerRepository _walkerRepository;
        private readonly IMapper _mapper;
        public WalkerService(IWalkerRepository walkerRepository, IMapper mapper)
        {
            _walkerRepository = walkerRepository;
            _mapper = mapper;
        }

        public async Task<WalkerDto> GetAsync(Guid userId)
        {
            var walker = await _walkerRepository.GetAsync(userId);

            return _mapper.Map<Walker,WalkerDto>(walker);
        }
    }
}