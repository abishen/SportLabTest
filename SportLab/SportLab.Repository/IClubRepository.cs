using SportLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportLab.Repository
{
    public interface IClubRepository
    {
        Task<IEnumerable<FootBallClub>> GetFootBallClubAsync();
        Task<FootBallClub> GetFootBallClubByIdAsync(int id);
        Task UpdateFootBallClubInfoAsync(FootBallClub footBallClub);
    }
}