using Dao.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dao
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDaoModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<QuestionAndAnswerDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("QuestionAndAnswerDBConnection")));
            return services;
        }
    }
}