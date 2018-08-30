using System;
using System.Collections.Generic;
using System.Text;

namespace TFTServer.Shared.ModelsDto
{
    public class FullTournamentTreeDto : BaseDto
    {
        public int Rows { get; set; }
        public List<TeamForTournamentTree> Teams { get; set; }
    }
}
