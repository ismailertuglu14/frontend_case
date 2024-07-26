using AutoMapper;
using Shop.Core.DTOs.User;
using Shop.Entity.Entities;
using Shop.Repository.IRepository;
using Shop.Services.IServices;
using System.Diagnostics;

namespace Shop.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<SigninResponse> Signin(SignupDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<SigninResponse> Signup(SigninDto dto)
        {
            try
            {
                User user = _mapper.Map<User>(dto);
                return new() { };
            }
            catch (Exception ex) 
            {
                Debug.WriteLine(ex);
                throw;
            }
        }
    }
}
