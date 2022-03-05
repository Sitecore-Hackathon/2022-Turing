﻿using GraphQL;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Mvp.Feature.Reviews.Infrastructure
{
	public interface IGraphQLProvider
	{
		Task<GraphQLResponse<TResponse>> SendQueryAsync<TResponse>(bool? isEditMode, GraphQLFiles queryFile, dynamic? variables) where TResponse : class;
	}
}
