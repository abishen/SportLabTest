using SportLab.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using SportLab.Domain.Entities;
using SportLab.ViewModel;

namespace SportLab.Services
{
    public class ClubServices : IClubServices
    {
        private IClubRepository _clubRepository;
        public ClubServices(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }
        public async Task<IEnumerable<ClubsViewModel>> GetFootballClubAsync()
        {
            var data = (await _clubRepository.GetFootBallClubAsync()).Select( x => new ClubsViewModel { 
            Id = x.Id,
            Country = x.Country,
            Name = x.Name,
            Eliminated = x.Eliminated
            
            });
            return data ;
        }

        public async Task<ClubsViewModel> GetFootballClubByIdAsync(int id)
        {
            var footballClub = await _clubRepository.GetFootBallClubByIdAsync(id);
            return new ClubDetailViewModel { 
             Id = footballClub.Id,
             Country = footballClub.Country,
             Name = footballClub.Name,
             Eliminated = footballClub.Eliminated
            
            } ;
        }

        public async Task UpdateFootClubAsync(ClubsViewModel viewModel)
        {
            if (viewModel == null) return;
            await _clubRepository.UpdateFootBallClubInfoAsync(viewModel.ToEntities());
        }

    }

    public static class Extensions {

        public static FootBallClub ToEntities(this ClubsViewModel viewModel)
            => new FootBallClub()
            {
                Country = viewModel.Country,
                Eliminated = viewModel.Eliminated,
                Id = viewModel.Id,
                Name = viewModel.Name
            };
    
    }
}
