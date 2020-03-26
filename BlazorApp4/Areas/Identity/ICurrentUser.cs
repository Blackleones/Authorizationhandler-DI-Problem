using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Areas.Identity
{
    public interface ICurrentUser
    {
        Task<string> GetUserId();
    }

    public class CurrentUser : ICurrentUser
    {
        private readonly AuthenticationStateProvider _provider;

        public CurrentUser(AuthenticationStateProvider provider)
        {
            _provider = provider;
        }

        public async Task<string> GetUserId()
        {
            var authState = await _provider.GetAuthenticationStateAsync();
            var user = authState.User;

            return user.Identity.IsAuthenticated ? user.Identity.Name : null;
        }
    }
}
