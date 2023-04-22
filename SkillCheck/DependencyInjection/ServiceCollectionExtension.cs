using Microsoft.EntityFrameworkCore;
using SkillCheck_BE_BusinessServices_Audits.Service.Implementation;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;
using SkillCheck_BE_DataRepository_Audits.DataAccess;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Implementation;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Interface;

namespace SkillCheck.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            
            AddDbContext(services, configuration);
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }

        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services
                .AddScoped<ITechnologyRepository, TechnologyRepo>()
                .AddScoped<IAuditCheckRepository, AuditCheckRepo>()
                .AddScoped<IAuditRepository, AuditRepo>()
                .AddScoped<IAccountRepository, AccountRepo>();


            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            /// Add service registration here
            /// eg.
            /// services.AddScoped<IService, Service>();
            /// 
            services
           .     AddScoped<IAuditService, AuditService>()
                .AddScoped<IAuditCheckService, AuditCheckService>()
                .AddScoped<ITechnologyService, TechnologyService>()
                .AddScoped<IAccountService, AccountService>();
            return services;
        }

        private static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var isProduction = configuration.GetValue<bool>("InProduction");

            if (isProduction)
            {
                services.AddDbContext<SkillCheckDb>(options =>
                {
                    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
                });
            } 
            else
            {
                services.AddDbContext<SkillCheckDb>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                });
            }
            return services;
        }
    }
}
