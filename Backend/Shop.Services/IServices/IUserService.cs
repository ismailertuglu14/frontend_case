using Shop.Core.DTOs.User;

namespace Shop.Services.IServices
{
    public interface IUserService
    {
        Task<SigninResponse> Signin(SignupDto dto);
        Task<SigninResponse> Signup(SigninDto dto);
    }
}
