using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainModule(this IServiceCollection services, IConfiguration configuration)
        {
           
            // Cấu hình MediatR
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
            services.AddMediatR(typeof(DependencyInjection).GetTypeInfo().Assembly);

            return services;
        }
    }
}
