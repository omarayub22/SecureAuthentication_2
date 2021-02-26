using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService // does not contain any implementation logics---it only contains the signature of the functinality
    {
      string CreateToken(AppUser user);
    }
}