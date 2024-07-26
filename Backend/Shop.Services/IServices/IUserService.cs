using Shop.Core.DTOs.Base;
using Shop.Core.DTOs.User;

namespace Shop.Services.IServices
{
    public interface IUserService
    {
        Task<Response<TokenDto>> Signin(SigninDto dto);
        Task<Response<TokenDto>> Signup(SignupDto dto);
    }
}
