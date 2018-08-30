using System;
using System.Collections.Generic;
using System.Text;

namespace TFTServer.Shared.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? EndedAt { get; set; }
        public int TeamsCountOnBottom { get; set; }
    }
}
