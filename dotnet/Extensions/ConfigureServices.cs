using dotnet.Context;
using dotnet.Repositories.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Extensions
{
    public static class ConfigureService 
    {
        public static IServiceCollection ConfigureDefault(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Api Title", Version = "v1" });

            });
            return services;
        }
        public static IServiceCollection ConfigureInjectionDependencys(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();  
            return services;
        }

        public static IServiceCollection ConfigureConnectionString(this IServiceCollection services, IConfiguration configuration)
        {
            string? sqlConnection = configuration.GetConnectionString("stringConnection");
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(sqlConnection));
            return services;
        }
    }
}
