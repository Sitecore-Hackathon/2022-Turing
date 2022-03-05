using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mvp.Feature.Reviews.Rendering.Models;

namespace Mvp.Feature.Reviews.Services
{
	public interface IGraphQLReviewsService
	{
		SearchParams CreateSearchParams();
		Task<SubmissionsSearchResults> Search(SearchParams searchParams);
	}
}
