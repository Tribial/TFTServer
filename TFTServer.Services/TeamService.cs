using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TFTServer.Repositories.Interfaces;
using TFTServer.Services.Interfaces;
using TFTServer.Shared.BindingModels;
using TFTServer.Shared.Models;
using TFTServer.Shared.ModelsDto;

namespace TFTServer.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly ITournamentRepository _tournamentRepository;

        public TeamService(ITeamRepository teamRepository, ITournamentRepository tournamentRepository)
        {
            _teamRepository = teamRepository;
            _tournamentRepository = tournamentRepository;
        }

        public async Task<Response<BaseDto>> AddTeamAsync(TeamBindingModel team)
        {
            Response<BaseDto> response = new Response<BaseDto>();
            var teamToAdd = Mapper.Map<Team>(team);

            var addedSuccessfuly = await _teamRepository.AddTeamAsync(teamToAdd);

            if (!addedSuccessfuly)
            {
                response.Errors.Add("Wystapił problem przy dodawaniu drużyny, spróbuj ponownie później");
            }

            return response;
        }

        public Responses<TeamDto> GetTeamsForTournament(int tournamentId)
        {
            var result = new Responses<TeamDto> {Objects = new List<TeamDto>()};
            if (!_tournamentRepository.Exists(tournamentId))
            {
                result.Errors.Add("Turniej o podanym id nie istnieje");
                return result;
            }

            var tournamentTeams = _teamRepository.GetTournamentTeamsByTournamentId(tournamentId).ToList();

            tournamentTeams.ForEach(t =>
            {
                var team = _teamRepository.GetTeam(r => r.Id == t.TeamId);
                if (team != null)
                {
                    result.Objects.Add(Mapper.Map<TeamDto>(team));
                }
            });

            return result;
        }
    }
}
