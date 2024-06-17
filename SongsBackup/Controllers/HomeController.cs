using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SongsBackup.Interfaces;
using SongsBackup.Models;
using SongsBackup.Models.SpotifyModels;
using SongsBackup.Models.SpotifyModels.RequestModel;
using SongsBackup.ViewModel;

namespace SongsBackup.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IFileService fileService;
    private readonly ISpotifyService spotifyService;
    private readonly ISessionService sessionService;

    public HomeController(
        ILogger<HomeController> logger, 
        IFileService fileService, 
        ISpotifyService spotifyService,
        ISessionService sessionService)
    {
        _logger = logger;
        this.fileService = fileService;
        this.spotifyService = spotifyService;
        this.sessionService = sessionService;
    }

    public async Task<IActionResult> Home()
    {
        var profile = await this.spotifyService.GetProfile();
        
        return this.View(this.BuildViewModel(profile));
    }
    
}