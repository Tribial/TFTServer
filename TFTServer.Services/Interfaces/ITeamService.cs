using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TFTServer.Shared.BindingModels;
using TFTServer.Shared.ModelsDto;

namespace TFTServer.Services.Interfaces
{
    public interface ITeamService
    {
        Task<Response<BaseDto>> AddTeamAsync(TeamBindingModel team);
        Responses<TeamDto> GetTeamsForTournament(int tournamentId);
    }
}
