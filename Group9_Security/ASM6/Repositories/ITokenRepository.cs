using Microsoft.AspNetCore.Identity;

namespace ASM6.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
