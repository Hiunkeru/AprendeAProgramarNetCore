using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.IO;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using AprendeNetCore2.Middleware;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AprendeNetCore2.DataAccess.DBModels;
using AprendeNetCore2.DataAccess;
using Swashbuckle.AspNetCore.Filters;
using AprendeNetCore2.Examples;

namespace AprendeNetCore2
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Habilitar, para usar IOptions<>
            //services.AddOptions();
            //services.Configure<Address>(Configuration.GetSection("address"));
            //services.Configure<AppSettings>(Configuration);

            services.AddMemoryCache();

            services.AddDbContext<AprendeDBFirstContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AprendeDBFirst")));

            services.AddDbContext<NBAContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddApplicationInsightsTelemetry();
            
            services.AddMvc();

            IoC.AddRegistration(services);

            //var filePath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "AprendeNetCore2.xml");

            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info()
                {
                    Title = "Ejemplo de Swagger"
                });

                config.ExampleFilters();

               
                //config.IncludeXmlComments(filePath);

                //config.AddSecurityDefinition("Bearer", new OAuth2Scheme()
                //{
                //    Description = "Autentification Oauth2",
                //    TokenUrl = "https://identityServer.azurewebsites.net/oauth2/token",
                //    Flow = "password",
                //    Type = "oauth2"
                //});

                config.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWT Token usar Bearer {token}",
                    Name = "Authoritation",
                    In = "header",
                    Type = "apiKey" //string
                });


            });

            services.AddSwaggerExamplesFromAssemblyOf<ExamplesSwagger>();
            services.AddSwaggerExamplesFromAssemblyOf<ExamplesResponseListPlayersSwagger>();
            services.AddSwaggerExamplesFromAssemblyOf<ExamplesResponseSwagger>();
            

            //services.AddSwaggerExamples();

            services.AddAuthorization(options => {
                options.DefaultPolicy = new AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .Build();
                });


            var issuer = Configuration["AuthenticationSettings:Issuer"];
            var audience = Configuration["AuthenticationSettings:Audience"];
            var signingKey = Configuration["AuthenticationSettings:SigningKey"];

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(o =>
            {
                o.Audience = audience;
                o.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(signingKey))
                };
            }

            );


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //app.UseAuthentication();

            //app.Map("/api/values", configuration =>
            //{
            //    app.UseMvc();
            //});

            app.MapWhen(context => context.Request.Method == "Get" ,context => {
                Console.Write("Es un Get");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseLogMiddleware();
            app.UseEjemplo();

            app.UseSwagger();
            app.UseSwaggerUI(config =>
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "API de ejemplo SWAGGER")
            );

            app.UseMvc();

        }
    }
}
