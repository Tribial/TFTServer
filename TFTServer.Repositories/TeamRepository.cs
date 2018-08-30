using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TFTServer.Repositories.Data;
using TFTServer.Repositories.Interfaces;
using TFTServer.Shared.Models;

namespace TFTServer.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TeamRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddTeamAsync(Team team)
        {
            await _dbContext.AddAsync(team);
            return await SaveAsync();
        }

        public IEnumerable<TournamentTeam> GetTournamentTeamsByTournamentId(int tournamentId)
        {
            return _dbContext.TournamentTeams.Where(t => t.TournamentId == tournamentId);
        }

        public Team GetTeam(Func<Team, bool> func)
        {
            return _dbContext.Teams.FirstOrDefault(func);
        }

        private async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
