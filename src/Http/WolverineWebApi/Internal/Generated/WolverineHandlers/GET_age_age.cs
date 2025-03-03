// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_age_age
    public class GET_age_age : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _options;

        public GET_age_age(Wolverine.Http.WolverineHttpOptions options) : base(options)
        {
            _options = options;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            if (!int.TryParse((string)httpContext.GetRouteValue("age"), out var age))
            {
                httpContext.Response.StatusCode = 404;
                return;
            }


            // Just saying hello in the code! Also testing the usage of attributes to customize endpoints
            var result_of_IntRouteArgument = WolverineWebApi.TestEndpoints.IntRouteArgument(age);
            await WriteString(httpContext, result_of_IntRouteArgument);
        }

    }

    // END: GET_age_age
    
    
}

