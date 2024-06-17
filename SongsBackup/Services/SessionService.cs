namespace SongsBackup.Services
{
    using System.Globalization;
    
    using SongsBackup.Models.SpotifyModels;
    using SongsBackup.Interfaces;
    
    public class SessionService : ISessionService
    {
        private readonly IHttpContextAccessor httpContext;

        public SessionService(IHttpContextAccessor httpContext)
        {
            this.httpContext = httpContext;
        }
        
        public void SetSessionData(SpotifyTokenResponse token)
        {
            this.httpContext.HttpContext!.Session.SetString(nameof(SpotifyTokenResponse.AccessToken), token.AccessToken);
            this.httpContext.HttpContext!.Session.SetString(nameof(SpotifyTokenResponse.RefreshToken), token.RefreshToken);
            this.httpContext.HttpContext!.Session.SetString(nameof(SpotifyTokenResponse.ExpiresAt), DateTime.Now.AddSeconds(token.ExpiresIn).ToString(CultureInfo.InvariantCulture));
        }

        public SpotifyTokenResponse GetSessionData()
        {
            return new()
            {
                AccessToken = this.httpContext.HttpContext.Session.GetString(nameof(SpotifyTokenResponse.AccessToken)),
                RefreshToken = this.httpContext.HttpContext.Session.GetString(nameof(SpotifyTokenResponse.RefreshToken)),
                ExpiresAt = this.httpContext.HttpContext.Session.GetString(nameof(SpotifyTokenResponse.ExpiresAt))
            };
        }
    }
}