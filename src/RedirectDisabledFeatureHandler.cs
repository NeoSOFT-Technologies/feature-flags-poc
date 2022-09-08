using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.FeatureManagement.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestFeatureFlags
{
    public class RedirectDisabledFeatureHandler : IDisabledFeaturesHandler
    {
        public Task HandleDisabledFeatures(IEnumerable<string> features, ActionExecutingContext context)
        {
            context.Result = new ContentResult()
            {
                Content = $"<p>The following feature(s) is not available for you.</p>" +
                 $"<p>Please contact support for more information.</p>",
                ContentType = "text/html"
            };
            return Task.CompletedTask;
        }
    }
}
