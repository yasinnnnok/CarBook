using Applicaton.Features.Mediator.Results.FeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeautureQuery:IRequest<List<GetFeatureQueryResult>>
    {

    }



}
