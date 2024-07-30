using Microsoft.AspNetCore.Http;
using Shop.Core.Utils;
using Shop.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Services
{
    public class BaseService
    {
        public IHttpContextAccessor _httpContextAccessor { get; set; }

        public string Token => _httpContextAccessor.HttpContext.Request.Headers["Authorization"];
        public int UserId { get { return GetUserId(); } }
        private readonly TokenService _tokenService;
        public BaseService(IHttpContextAccessor httpContextAccessor, TokenService tokenService)
        {
            _httpContextAccessor = httpContextAccessor;
            _tokenService = tokenService;
        }


        private int GetUserId()
        {
            return _tokenService.GetUserIdByToken(Token);
        }
    }
}
