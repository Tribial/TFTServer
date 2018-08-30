using System;
using System.Collections.Generic;
using System.Text;

namespace TFTServer.Shared.Models
{
    public class TournamentTeam
    {
        public int TournamentId { get; set; }
        public int TeamId { get; set; }
        public int RowNumber { get; set; }
        public int PlaceNumber { get; set; }
        public bool HasLost { get; set; }
    }
}
