using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Shop.Core.DTOs.Base;
using Shop.Core.DTOs.User;
using Shop.Core.Utils;
using Shop.Entity.Entities;
using Shop.Repository.IRepository;
using Shop.Services.IServices;
using System.Diagnostics;

namespace Shop.Services.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly TokenService _tokenService;
        public UserService(IUserRepository repository, IMapper mapper, 
            IHttpContextAccessor httpContextAccessor,
            TokenService tokenService) : base(httpContextAccessor, tokenService)
        {
            _repository = repository;
            _mapper = mapper;
            _tokenService = tokenService;
        }

        public async Task<Response<User>> GetUser()
        {
            User user = await _repository.GetWhereAsync(u => u.Id == this.UserId, 
                query => query.Include(u => u.Carts).ThenInclude(c => c.CartItems)
                );
            if(user != null) return Response<User>.Success(user);
            return Response<User>.Fail(Core.DTOs.Base.StatusCodes.NOT_FOUND, "User not found");
        }

        public async Task<Response<TokenDto>> Signin(SigninDto dto)
        {
            try
            {
                User? user = await _repository.GetWhereAsync(u => u.Username == dto.Username && u.Password == dto.Password);
                if(user == null) return Response<TokenDto>.Fail(Core.DTOs.Base.StatusCodes.NOT_FOUND, "Username or Password wrong!");
                TokenDto response = new()
                {
                    User = user,
                    AccessToken = _tokenService.GenerateToken(user).AccessToken
                };
                return Response<TokenDto>.Success(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return Response<TokenDto>.Fail(Core.DTOs.Base.StatusCodes.SERVER_ERROR);

            }
        }

        public async Task<Response<TokenDto>> Signup(SignupDto dto)
        {
            try
            {
                User? user = await _repository.GetWhereAsync(u => u.Username == dto.Username);
                if (user != null) return  Response<TokenDto>.Fail(Core.DTOs.Base.StatusCodes.FAIL, "Username must be unique");
                User mappedUser = _mapper.Map<User>(dto);
                User createdUser = await _repository.InsertAsync(mappedUser);
                await _repository.SaveChangesAsync();
                TokenDto response = new()
                {
                    User = createdUser,
                    AccessToken = _tokenService.GenerateToken(createdUser).AccessToken
                };
                return Response<TokenDto>.Success(response);
            }
            catch (Exception ex) 
            {
                Debug.WriteLine(ex);
                return Response<TokenDto>.Fail(Core.DTOs.Base.StatusCodes.SERVER_ERROR);
            }
        }
    }
}
