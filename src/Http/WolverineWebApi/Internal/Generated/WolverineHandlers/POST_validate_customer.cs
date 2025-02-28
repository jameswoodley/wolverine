// <auto-generated/>
#pragma warning disable
using FluentValidation;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using Wolverine.Http.FluentValidation;
using Wolverine.Http.FluentValidation.Internals;
using WolverineWebApi.Validation;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_validate_customer
    public class POST_validate_customer : Wolverine.Http.HttpHandler
    {
        private readonly WolverineHttpOptions _options;
        private readonly IValidator<CreateCustomer> _validator;
        private readonly IProblemDetailSource<CreateCustomer> _problemDetailSource;

        public POST_validate_customer(WolverineHttpOptions options, IValidator<CreateCustomer> validator, ProblemDetailSource<CreateCustomer> problemDetailSource) : base(options)
        {
            _options = options;
            _validator = validator;
            _problemDetailSource = problemDetailSource;
        }



        public override async Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var (customer, jsonContinue) = await ReadJsonAsync<CreateCustomer>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            var result = await FluentValidationHttpExecutor.ExecuteOne<CreateCustomer>(_validator, _problemDetailSource, customer).ConfigureAwait(false);
            if (!(result is WolverineContinue))
            {
                await result.ExecuteAsync(httpContext).ConfigureAwait(false);
                return;
            }

            var result_of_Post = ValidatedEndpoint.Post(customer);
            await WriteString(httpContext, result_of_Post);
        }

    }

    // END: POST_validate_customer
    
    
}

