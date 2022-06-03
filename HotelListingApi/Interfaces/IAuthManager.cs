using HotelListingApi.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListingApi.Interfaces
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto apiUser);
        Task<AuthResponseDto> Login(ApiLoginDto apiLoginDto);
        Task<string> CreateRefreshToken();
        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
    }
}
