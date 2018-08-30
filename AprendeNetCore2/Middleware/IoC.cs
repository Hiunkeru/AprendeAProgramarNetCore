using AprendeNetCore2.Application.Client;
using AprendeNetCore2.Application.Contracts;
using AprendeNetCore2.Application.Services;
using AprendeNetCore2.DataAccess;
using AprendeNetCore2.DataAccess.Repository;
using AprendeNetCore2.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {

            services.AddSingleton<IPlayerService, PlayerService>();

            services.AddTransient<IPlayerService, PlayerService>();

            services.AddScoped<IPlayerService, PlayerService>();

            services.AddScoped<IAuthService, AuthService>();

            services.AddScoped<IPlayerRepository, PlayerRepository>();

            services.AddScoped<INBAContext, NBAContext>();

            services.AddScoped<IYoutubeClient, YoutubeClient>();

            services.AddScoped<IYoutubeService, YoutubeService>();

            services.AddScoped<ITweeterService, TweeterService>();

            services.AddScoped<IFileAzureService, FileAzureService>();

            services.AddScoped<IunitOfWork, unitOfWork>(); 



            return services;
        }

    }
}
