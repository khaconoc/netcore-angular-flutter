using System.Reflection;
using Domain._Base.Behaviors;
using Domain.Services;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainModule(this IServiceCollection services, IConfiguration configuration)
        {
            // DI mediator
            services.AddMediatR(Assembly.GetExecutingAssembly());
            
            // DI auto mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            
            // DI validator
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            
            // DI Bahavior
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorBehavior<,>));
            // services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            
            // DI User Service
            services.AddScoped<IUserService, UserService>();
            
            return services;
        }
    }
}