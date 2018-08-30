using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TFTServer.Repositories.Data;
using TFTServer.Repositories.Interfaces;

namespace TFTServer.Repositories
{
    public class TournamentRepository : ITournamentRepository
    {
        private ApplicationDbContext _dbContext;

        public TournamentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Exists(int id)
        {
            return _dbContext.Tournaments.Any(t => t.Id == id);
        }
    }
}
