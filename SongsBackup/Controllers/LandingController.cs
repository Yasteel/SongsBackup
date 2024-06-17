namespace SongsBackup.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using SongsBackup.Models.SpotifyModels;
    using SongsBackup.ViewModel;

    public class LandingController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Connect()
        {
            return this.RedirectToAction("Login", "Auth");
        }

        public IActionResult AfterConnect()
        {
            
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