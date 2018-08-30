using System.Text;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TFTServer.Repositories;
using TFTServer.Repositories.Interfaces;
using TFTServer.Shared.BindingModels;
using TFTServer.Shared.Models;
using TFTServer.Shared.ModelsDto;

namespace TFTServer.Services
{
    public static class PassedConfig
    {
        public static void Config(IConfiguration configuration, IServiceCollection services)
        {
            var config = new StartUpConfig(configuration);
            config.PartOfConfigureServices(services);

            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<ITournamentRepository, TournamentRepository>();


            AutoMapperConfiguration();
        }

        private static void AutoMapperConfiguration()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<TeamBindingModel, Team>();

                config.CreateMap<Team, TeamDto>();
            });
        }
    }
}
