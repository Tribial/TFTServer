using System;
using System.Collections.Generic;
using System.Text;

namespace TFTServer.Shared.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
    }
}
