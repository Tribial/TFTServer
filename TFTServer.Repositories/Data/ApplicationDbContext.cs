using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using TFTServer.Shared.Models;

namespace TFTServer.Repositories.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<TournamentTeam> TournamentTeams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Team>()
                .HasKey(e => e.Id);

            builder.Entity<TournamentTeam>()
                .HasKey(e => new {e.TeamId, e.TournamentId});

            builder.Entity<Tournament>()
                .HasKey(e => e.Id);
        }
    }
}
