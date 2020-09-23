﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using ElectionResults.Core.Endpoints.Query;
using ElectionResults.Core.Endpoints.Response;
using ElectionResults.Core.Entities;

namespace ElectionResults.Core.Elections
{
    public interface IResultsAggregator
    {
        Task<Result<List<ElectionMeta>>> GetAllBallots();

        Task<Result<ElectionResponse>> GetBallotResults(ElectionResultsQuery query);

        Task<Result<List<County>>> GetCounties();
        Task<Result<List<Locality>>> GetLocalities(int? countyId);
        Task<Result<List<Locality>>> GetCountries();
    }
}