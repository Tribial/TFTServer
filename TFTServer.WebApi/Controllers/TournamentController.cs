using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TFTServer.Shared.ModelsDto;

namespace TFTServer.WebApi.Controllers
{
    [Route("api/Tournaments")]
    [ApiController]
    public class TournamentController : BaseController
    {
        //private readonly IHubContext<UpdateHub> _hubContext;

        //public TournamentController(IHubContext<UpdateHub> hubContext)
        //{
        //    _hubContext = hubContext;
        //}
        [HttpGet]
        public IActionResult TestNetwork()
        {
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> AddTournamentAsync()
        {
            var start = DateTime.Now;
            var end = start;
            while (true)
            {
                if ((end - start).Seconds > 30)
                {
                    break;
                }
                end = DateTime.Now;
            }
            var tournamentTree = new FullTournamentTreeDto();
            //await _hubContext.Clients.All.SendAsync("ReceiveUpdate", "Hello there, I'm calling from the server");
            return Ok();
        }
    }
}
