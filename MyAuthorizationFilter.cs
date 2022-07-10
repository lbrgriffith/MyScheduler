using Hangfire.Dashboard;

namespace MyScheduler;

public class MyAuthorizationFilter : IDashboardAuthorizationFilter
{
    public bool Authorize(DashboardContext context)
    {
        var httpContext = context.GetHttpContext();

        // IMPORTANT: Allowing authenticated users to see the Dashboard is potentially dangerous!
        return httpContext.User.Identity.IsAuthenticated;
    }
}
