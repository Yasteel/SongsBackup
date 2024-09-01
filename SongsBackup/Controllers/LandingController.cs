using SongsBackup.Interfaces;

namespace SongsBackup.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using SongsBackup.Models.SpotifyModels;
    using SongsBackup.ViewModel;

    public class LandingController : Controller
    {
        private readonly ISpotifyService spotifyService;

        public LandingController(ISpotifyService spotifyService)
        {
            this.spotifyService = spotifyService;
        }
        
        public async Task<IActionResult> Index(HomeViewModel? viewModel)
        {
            var profile = await this.spotifyService.GetProfile();
            return this.View(this.BuildViewModel(profile));
        }
        
        public IActionResult Connect()
        {
            return this.RedirectToAction("Login", "Auth");
        }
        
        private HomeViewModel BuildViewModel(ProfileResponse? profile)
        {
            var profileImage = string.Empty;

            if (profile.Images.Length == 1)
            {
                profileImage = profile.Images[0].Url;
            }
            else
            {
                var largest = profile.Images.AsQueryable()
                    .OrderByDescending(_ => _.Width)
                    .ToArray();

                profileImage = largest[0].Url;
            }

            return new()
            {
                DisplayName = profile!.DisplayName,
                ProfileImage = profileImage 
            };
        }
    }
}