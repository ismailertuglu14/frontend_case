using Shop.Core.DTOs.Base;
using Shop.Core.DTOs.User;
using Shop.Entity.Entities;

namespace Shop.Services.IServices
{
    public interface IUserService
    {
        Task<Response<User>> GetUser();
        Task<Response<TokenDto>> Signin(SigninDto dto);
        Task<Response<TokenDto>> Signup(SignupDto dto);
    }
}
