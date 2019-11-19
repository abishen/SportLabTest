using Microsoft.EntityFrameworkCore;
using SportLab.Domain.Entities;
using System;

namespace SportLab.Data
{
    public class SportLabContext : DbContext 
    {

        public SportLabContext(DbContextOptions<SportLabContext> options) : base(options) {}
        public DbSet<FootBallClub> FootBallClubs { get; set; }

    }
}
