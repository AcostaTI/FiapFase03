using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TechchallengeNoticias.Models;

namespace TechchallengeNoticias.Services
{
    public class TokenService
    {
        public string GenerateToken(Usuario usuario)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("username", usuario.UserName),
                new Claim("id", usuario.Id),
                new Claim("securitystamp",usuario.SecurityStamp)
            };

            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("65DA65DAS54D654DAS6D4A6S54D8A4D852AS4D85"));

            var signingCredentials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
            (
               expires: DateTime.Now.AddMinutes(10),
               claims: claims,
               signingCredentials: signingCredentials

            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
