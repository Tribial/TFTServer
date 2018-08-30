using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using TFTServer.Services.Interfaces;
using TFTServer.Shared.BindingModels;
using TFTServer.Shared.ModelsDto;

namespace TFTServer.WebApi.Controllers
{
    [Route("api/Teams")]
    [ApiController]
    public class TeamController : BaseController
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpPost]
        public async Task<IActionResult> AddTeamAsync([FromBody] TeamBindingModel team)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelStateErrors());
            }

            var result = await _teamService.AddTeamAsync(team);

            if (result.ErrorOccurred)
            {
                return BadRequest(result);
            }

            return Ok(result);

        }

        [HttpGet("{id}")]
        public IActionResult GetTeamsForTournament(int id)
        {
            var result = _teamService.GetTeamsForTournament(id);

            if (result.ErrorOccurred)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}