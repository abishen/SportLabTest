using SportLab.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportLab.Services
{
    public interface IClubServices
    {
        Task<IEnumerable<ClubsViewModel>> GetFootballClubAsync();
        Task<ClubsViewModel> GetFootballClubByIdAsync(int id);

        Task UpdateFootClubAsync(ClubsViewModel viewModel);
    }
}