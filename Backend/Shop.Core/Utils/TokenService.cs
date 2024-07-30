using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Shop.Core.DTOs;
using Shop.Core.DTOs.User;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Shop.Core.Utils
{
    public class TokenService
    {
        private readonly IConfiguration _configuration;
        private readonly JwtDto _jwt;
        public TokenService(IConfiguration configuration, IOptions<JwtDto> jwt)
        {
            _configuration = configuration;
            _jwt = jwt.Value;
        }

        public TokenDto GenerateToken(Shop.Entity.Entities.User user)
        {
            TokenDto token = new();
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_jwt.Secret));

            SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha256);
            var authClaims = new List<Claim>()
            {
                new(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            JwtSecurityToken securityToken = new(
                expires: DateTime.Now.AddDays(12),
                notBefore: DateTime.UtcNow, 
                signingCredentials: signingCredentials, 
                claims: authClaims
            );

            // Token oluşturucu sınıfından bir örnek alalım.
            JwtSecurityTokenHandler tokenHandler = new();
            token.AccessToken = tokenHandler.WriteToken(securityToken);
            return token;
        }
        public int GetUserIdByToken(string token)
        {
            if (token == null || token == "")
            {
                return 0;
            }

            var handler = new JwtSecurityTokenHandler();
            token = token.Split("Bearer ")[1];
            var jwtSecurityToken = handler.ReadJwtToken(token);
            var userId = jwtSecurityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            return Convert.ToInt32(userId);
        }

    }
}
