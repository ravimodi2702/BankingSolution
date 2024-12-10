using Banking.Api.Middleware;
using Banking.Application.Peristence;
using Banking.Application.UseCases.CustomerOnboard;
using Banking.Infrastructure.Persistence;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Banking.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddMediatR(x => x.RegisterServicesFromAssemblyContaining(typeof(CustomerOnboardCommandHandler)));
            services.AddValidatorsFromAssemblyContaining(typeof(CustomerOnboardingCommandValidator));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen();

          /*  services.AddAuthentication("Bearer").AddJwtBearer(x =>
            {
                x.Authority = "https://acivedirectlypath";
                x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = "issuername",
                    ValidAudience = "audiencename",
                    NameClaimType = "nameclaim"
                };
            });

            services.AddAuthorization(x =>
            {
                x.AddPolicy("IsManager", y => y.RequireRole("Manager"));
                x.AddPolicy("IsCustomer", y => y.RequireRole("Customer"));
               // x.DefaultPolicy = "IsCustomer";
            });*/

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
          //  app.UseAuthentication();
           // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
