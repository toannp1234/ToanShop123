using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ToanShop.WebApp.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetSpecificClaim(this ClaimsPrincipal claimsPrincipal,string claimTypes) {
            var claim = claimsPrincipal.Claims.FirstOrDefault(x => x.Type == claimTypes);
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}
