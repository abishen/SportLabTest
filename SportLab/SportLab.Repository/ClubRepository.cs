using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SportLab.Data;
using SportLab.Domain.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SportLab.Repository
{
    public class ClubRepository : IClubRepository
    {
        private SportLabContext  _db;
        public ClubRepository(SportLabContext db)
        {
            _db = db;
        }
        public async  Task<IEnumerable<FootBallClub>> GetFootBallClubAsync()
        {
            return await _db.FootBallClubs.ToListAsync();
        }

        public Task<FootBallClub> GetFootBallClubByIdAsync(int id)
        {
            return _db.FootBallClubs.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateFootBallClubInfoAsync(FootBallClub footBallClub)
        {
            await Task.FromResult(_db.FootBallClubs.Update(footBallClub));
            await _db.SaveChangesAsync();
        }
    }
}
