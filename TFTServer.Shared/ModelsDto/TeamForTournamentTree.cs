using System;
using System.Collections.Generic;
using System.Text;

namespace TFTServer.Shared.ModelsDto
{
    public class TeamForTournamentTree : BaseDto
    {
        public string Name { get; set; }
        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public int RowNumber { get; set; }
        public int PlaceNumber { get; set; }
        public bool HasLost { get; set; }
    }
}
