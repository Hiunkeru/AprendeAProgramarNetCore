using AprendeNetCore2.Services.Contracts;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AprendeNetCore2.Application.Contracts
{
    public class AuthService : IAuthService
    {

        public bool ValidateLogin(string user, string pass)
        {

            //Validamos a nuestro gusto.

            return true;

        }

        public string GenerateToken(DateTime date, string user, TimeSpan validDate)
        {

            var expire = date.Add(validDate);

            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(
                    JwtRegisteredClaimNames.Iat,
                    new DateTimeOffset(date).ToUniversalTime().ToUnixTimeSeconds().ToString(),
                    ClaimValueTypes.Integer64
                ),
                new Claim("roles","Cliente"),
                new Claim("roles","Administrador")
            };

            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes("aaAAaaAA1234sdsdsdsddferrtrfgfgfrgfgfgdgfdfdf")),
                SecurityAlgorithms.HmacSha256Signature
            );

            var jwt = new JwtSecurityToken(
            issuer: "Ejemplo",
            audience: "Public",
            claims: claims,
            notBefore: date,
            expires: expire,
            signingCredentials: signingCredentials
            );

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            return encodedJwt;
        }

    }
}
