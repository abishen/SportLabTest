using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportLab.Services;
using SportLab.ViewModel;

namespace SportLab.Web.Controllers
{
    public class ClubController : Controller
    {
        private IClubServices _clubServices;

        public ClubController(IClubServices clubServices)
        {
            _clubServices = clubServices;
        }
        // GET: Club
        public async Task<ActionResult> Index()
        {
            return View(await _clubServices.GetFootballClubAsync());
        }

        // GET: Club/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _clubServices.GetFootballClubByIdAsync(id));
        }


        // POST: Club/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Details(ClubsViewModel clubsViewModel)
        {
            try
            {
                if (clubsViewModel == null) return View();

                await _clubServices.UpdateFootClubAsync(clubsViewModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}