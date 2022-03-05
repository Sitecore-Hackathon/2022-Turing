using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Mvp.Feature.Reviews.Rendering.Infrastructure;
using Mvp.Feature.Reviews.Infrastructure;
using Mvp.Feature.Reviews.Services;

namespace Mvp.Feature.Reviews.Rendering.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddFeatureReviews(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<GraphQLRequestBuilder>();
            serviceCollection.AddHttpClient<ReviewsClientFactory>();
            serviceCollection.AddSingleton<IGraphQLProvider, GraphQLProvider>();
            serviceCollection.AddSingleton<IGraphQLReviewsService, GraphQLReviewsService>();

        }
    }
}
