using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TFTServer.Repositories.Data;

namespace TFTServer.Repositories
{
    public class StartUpConfig
    {
        private readonly IConfiguration _configuration;

        public StartUpConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void PartOfConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
