using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IJwtService
    {
        string GenerateJSONWebToken(User user);
        RefreshTokenData GenerateRefreshTokenData();
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
    }
}
