using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TFTServer.Shared.Models;

namespace TFTServer.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        Task<bool> AddTeamAsync(Team team);
        IEnumerable<TournamentTeam> GetTournamentTeamsByTournamentId(int tournamentId);
        Team GetTeam(Func<Team, bool> func);
    }
}
