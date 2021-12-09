using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Diary.Application.Interfaces;
using Diary.Infrastructure.Context;


namespace Diary.Infrastructure.IoC
{
    public static class InfraExtensions
    {
        public static IServiceCollection InfraRegister(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EFContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("SqlConnection"));
            });

            services.AddTransient<IEFContext, EFContext>();
       
            return services;
        }
    }
}
