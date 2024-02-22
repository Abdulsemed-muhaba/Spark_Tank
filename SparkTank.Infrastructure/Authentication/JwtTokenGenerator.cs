using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SparkTank.Application.Persistence.Contracts.Auth;
using SparkTank.Application.Persistence.Contracts.Common;
using SparkTank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SparkTank.Infrastructure.Authentication;
public class JwtTokenGenerator : IJwtTokenGenerator
{
    public readonly IDateTimeProvider _dateTimeProvider;
    public readonly Jwtsettings _jwtsettings;
    public JwtTokenGenerator(IOptions<Jwtsettings> jwtsettings, IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
        _jwtsettings = jwtsettings.Value;
        
    }
    public string GenerateToken(InvestorEntity investor)
    {
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_jwtsettings.Secret)), SecurityAlgorithms.HmacSha256Signature);
        var claims = new[]
        {
            //new Claim(JwtRegisteredClaimNames.Sub, investor.Id.ToString()),
            //new Claim(JwtRegisteredClaimNames.UniqueName, investor.Full_Name),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

        };

        var securityToken = new JwtSecurityToken(
                            issuer: _jwtsettings.Issuer,
                            audience: _jwtsettings.Audience,
                            claims: claims,
                            expires: _dateTimeProvider.CreateTime.AddMinutes(60),
                            signingCredentials: signingCredentials);

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }

    public string GenerateToken(StartupEntity startup)
    {
        throw new NotImplementedException();
    }
}