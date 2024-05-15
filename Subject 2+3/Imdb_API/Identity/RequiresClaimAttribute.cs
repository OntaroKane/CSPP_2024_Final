using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Drawing.Text;

namespace Imdb_API.Identity
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RequiresClaimAttribute : Attribute, IAuthorizationFilter
    {
        private readonly string _clainName;
        private readonly string _claimValue;

        public RequiresClaimAttribute(string clainName, string claimValue)
        {
            _clainName = clainName;
            _claimValue = claimValue;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        { 
            if(!context.HttpContext.User.HasClaim(_clainName, _claimValue)) 
            {
                context.Result = new ForbidResult();
            }

        }

    }
}
