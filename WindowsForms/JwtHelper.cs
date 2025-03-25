using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

public class JwtHelper
{
    // 🔹 Rastgele 256 bit güçlü bir secret key oluştur
    private static readonly string secretKey = Convert.ToBase64String(GenerateRandomKey());

    private static byte[] GenerateRandomKey()
    {
        using (var rng = RandomNumberGenerator.Create())
        {
            byte[] key = new byte[32]; // 256 bit için 32 byte
            rng.GetBytes(key);
            return key;
        }
    }


    public static string GenerateToken(string email)
    {
        var key = new SymmetricSecurityKey(Convert.FromBase64String(secretKey));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.Email, email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var token = new JwtSecurityToken(
            issuer: "yourapp",
            audience: "yourapp",
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(1), // Token süresi 1 dakika
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}


