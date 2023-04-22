using Microsoft.OpenApi.Models;
using SkillCheck.DependencyInjection;
using SkillCheck.Middleware;
using SkillCheck_BE_BusinessServices_Audits.Mapper;

namespace SkillCheck
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment env;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            this.configuration = configuration;
            this.env = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
            //         .AddMicrosoftIdentityWebApp(configuration.GetSection("AzureAd"));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo
                    {
                        Title = "SkillCheck API",
                        Version = "v1",
                        Description = "This is a SkillCheck API",
                        Contact = new OpenApiContact
                        {
                            Name = "Pratian",
                            Email = "subham.bose@pratian.com",
                        },
                    });
                });

            services
                .AddDataBase(configuration)
                .AddDomainServices()
                .AddServices()
                .AddAutoMapper(typeof(AutoMapperProfile));
                
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            // All middlewares should be present between UseRouting and UseEndpoints
            app.UseHttpsRedirection();
            // app.UseAuthentication();
            // app.UseAuthorization();
            app.UseCustomExceptionMiddleware();
            app
                .UseRouting()
                .UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
