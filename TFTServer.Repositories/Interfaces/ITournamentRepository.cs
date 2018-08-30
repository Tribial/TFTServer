using System;
using System.Collections.Generic;
using System.Text;

namespace TFTServer.Repositories.Interfaces
{
    public interface ITournamentRepository
    {
        bool Exists(int id);
    }
}
