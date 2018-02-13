using Design.Infrastructure.DTO;

namespace Design.Infrastructure.Services
{
    public interface IJwtHandler
    {
         JwtDto CreateToken(string email);
    }
}