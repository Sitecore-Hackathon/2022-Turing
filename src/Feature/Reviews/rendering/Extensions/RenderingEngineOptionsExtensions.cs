using Sitecore.AspNet.RenderingEngine.Configuration;
using Sitecore.AspNet.RenderingEngine.Extensions;

namespace Mvp.Feature.Reviews.Rendering.Extensions
{
    public static class RenderingEngineOptionsExtensions
    {
        public static RenderingEngineOptions AddFeatureReviews(this RenderingEngineOptions options)
        {
            options.AddViewComponent("ApplicationsListing", "ApplicationsListing");
            options.AddViewComponent("ApplicationDetail", "ApplicationDetail");
            return options;
        }
    }
}