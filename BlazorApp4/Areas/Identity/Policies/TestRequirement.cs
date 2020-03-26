using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp4.Areas.Identity.Policies
{
    public class TestRequirement : IAuthorizationRequirement
    {
    }

    public class TestRequirementHandler : AuthorizationHandler<TestRequirement>
    {
        private readonly ICurrentUser _currentUser;

        public TestRequirementHandler(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, TestRequirement requirement)
        {
            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}
